using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSpammer
{
    class Registrator5SIM
    {

        
        public static string BaseUrl = "http://api1.5sim.net/stubs/handler_api.php";
        public string ApiKey { get; set; }
        public string Referal { get; set; }
        public string Country { get; set; }
        /// <summary>
        /// ID in sms-activate and phone number
        /// </summary>
        public Dictionary<string, string> activationPhones;

        public Registrator5SIM(string apiKey, string referal, string counrty)
        {
            
            ApiKey = apiKey;
            Referal = referal;
            Country = counrty;
            activationPhones = new Dictionary<string, string>();
        }

        public async Task<string> GetNumber()
        {
            string request = BaseUrl+"?api_key=a13163e0458348e4b47f62bf8f440350&action=getNumber&country="+Country+"&service=wa&count=1";
            string response = await ApiRequest.GetRequestAsync(request);

            string[] statusIdPhone = response.Split(':');
            if (statusIdPhone[0]== "ACCESS_NUMBER")
            {
                activationPhones.Add(statusIdPhone[1], statusIdPhone[2]);
                return statusIdPhone[2];
            }
            else
            {
                throw new Exception(statusIdPhone[0]);
            }
           
        }
        public async Task<string> GetCode(string phone)
        {
            string request = BaseUrl + "?api_key=a13163e0458348e4b47f62bf8f440350&action=getStatus&id=" + activationPhones.FirstOrDefault(i => i.Value == phone).Key;
            string response = await ApiRequest.GetRequestAsync(request);
            string[] statusCode = response.Split(':');
            if (statusCode[0] == "STATUS_OK")
            {
                return statusCode[1];
            }
            else
            {
                throw new Exception(response);
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
        public async void setStatus(string phone,string statusCode)
        {
            string request = BaseUrl + "?api_key=" + ApiKey + "&action=setStatus&status="+statusCode+"&id=" + activationPhones.FirstOrDefault(i => i.Value == phone).Key;
            await ApiRequest.GetRequestAsync(request);
            
        }
    }
}
