using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WhatsAppSpammer
{
    public class SmsActivate : AbstractSmsRegistrator
    {
        /// <summary>
        /// ID in sms-activate and phone number
        /// </summary>
        public Dictionary<string, string> activationPhones;

        public  SmsActivate(string apiKey, string referal,string counrty) : base(apiKey, referal, counrty)
        {
            BaseUrl = "https://sms-activate.ru/stubs/handler_api.php";
            activationPhones = new Dictionary<string, string>();
        }
        public override async Task<string> GetNumber()
        {
            string request = BaseUrl + "?api_key=" + ApiKey + "&action=getNumber&service=wa&ref=" + Referal + "&country=" + Country;
            string response = await ApiRequest.GetRequestAsync(request);
            string[] statusIdPhone = response.Split(':');

            if (statusIdPhone[0].ToString().Contains("ACCESS_NUMBER"))
            {
                activationPhones.Add(statusIdPhone[1], statusIdPhone[2]);
                return statusIdPhone[2];
            }
            else
            {
                throw new Exception(response);
            }

        }

        public override async void PhoneReady(string phone)
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
        public override async Task<string> GetCode(string phone)
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
        public override async void SetStatus(string phone, string statusCode)
        {
            /* not needeed */
        }
    }
}
