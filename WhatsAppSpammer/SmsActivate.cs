using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSpammer
{
    public  class SmsActivate 
    {
        public static string BaseUrl = "https://sms-activate.ru/stubs/handler_api.php";
        public  string ApiKey { get; set; }
        public string Referal { get; set; }
        public string Country { get; set; }
        /// <summary>
        /// ID in sms-activate and phone number
        /// </summary>
        public Dictionary<string, string> activationPhones;
        public SmsActivate(string apiKey, string referal,string counrty)
        {
            ApiKey = apiKey;
            Referal = referal;
            Country = counrty;
            activationPhones = new Dictionary<string, string>();
        }
        public async Task<string> GetNumber()
        {

            string request = BaseUrl + "?api_key=" + ApiKey + "&action=getNumber&service=wa&ref=" + Referal + "&country=" + Country;
            string response = await ApiRequest.GetRequestAsync(request);
            string[] statusIdPhone = response.Split(':');
            switch (statusIdPhone[0])
            {
                case "NO_NUMBERS":
                    throw new Exception("No numbers");
                case "NO_BALANCE":
                    throw new Exception("No balance");
                case "BAD_ACTION":
                    throw new Exception("BAD_ACTION");
                case "BAD_SERVICE":
                    throw new Exception("BAD_SERVICE");
                case "BAD_KEY":
                    throw new Exception("BAD_KEY");
                case "ERROR_SQL":
                    throw new Exception("ERROR_SQL");
                case "BANNED":
                    throw new Exception("BANNED");
                case "ACCESS_NUMBER":
                    activationPhones.Add(statusIdPhone[1], statusIdPhone[2]);
                    return statusIdPhone[2];
                    break;
                default:
                    throw new Exception("Unexpected server respose: "+response);
            }
        }
        public async void PhoneReady(string phone)
        {
            string request = BaseUrl + "?api_key=" + ApiKey + "&action=setStatus&status=1&id=" + activationPhones.FirstOrDefault(i => i.Value == phone).Key;
            string response = await ApiRequest.GetRequestAsync(request);
            string[] statusCode = response.Split(':');
            if (statusCode[0] == "ACCESS_READY")
            {
                return;
            }
            else
            {
                throw new Exception(response);
            }
        }
        public async Task<string> GetCode(string phone)
        {
            string request = BaseUrl + "?api_key=" + ApiKey + "&action=getStatus&id=" + activationPhones.FirstOrDefault(i => i.Value==phone).Key;
            string response = await ApiRequest.GetRequestAsync(request);
            string[] statusCode = response.Split(':');
            if (statusCode[0] == "STATUS_OK")
            {
                return statusCode[1];
            }
            else if(statusCode[0] == "STATUS_WAIT_CODE" )
            {
                return "STATUS_WAIT_CODE";
            }
            else
            {
                throw new Exception(response);
            }
        }
    }
}
