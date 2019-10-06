using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappSpammer
{
    public class MessageSender
    {
        public string Url { get; set; }
        public string Token { get; set; }
        private Dictionary<string,NumberBase> NumberBases;
        private FileReader fileReader;

        /// <summary>
        /// Creating message sender to specific api and token with filereader
        /// </summary>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="filereaderPath"></param>
        public MessageSender(string url, string token, string filereaderPath)
        {
            Url = url;
            Token = token;
            NumberBases = new Dictionary<string, NumberBase>();
            fileReader = new FileReader(filereaderPath);
        }
        /// <summary>
        /// Sending message to url and returning respons
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="message"></param>
        /// <returns>Response from server</returns>
        public string sendMessage(string phone, string message)
        {
            string json = "{\"phone\":\"" + phone + "\"," +
                          "\"body\":\"" + message + "\"}";
            return SendJSON(json ,"sendMessage");
           
        }
        
        private string SendJSON(string json,string method)
        {
             try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Url+"/"+ method + "?token=" + Token);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                     return streamReader.ReadToEnd();
                }
            }
            catch(WebException e) {
                string errmsg = "Error: " + e.Message ;
                return errmsg;
            }
        }

        public void AddNumberBase(string filename)
        {
            NumberBases.Add(filename, fileReader.GetNumberBase(filename));
        }
        public void AddAllNumberBases()
        {
            foreach (var filename in fileReader.GetFilenames())
            {
                AddNumberBase(filename);
            }
        }
        public List<string> GetNumberBasesInDirectory()
        {
            return fileReader.GetFilenames();
        }
        public List<string> GetNumberBases()
        {
            return NumberBases.Keys.ToList(); ;
        }
        public List<string> SendMessages(string message)
        {
            List<string> responses = new List<string>(); ;
            foreach (var numberBase in NumberBases.Values)
            {
                foreach (var number in numberBase.Numbers)
                {
                    string response = sendMessage(number, message);
                    responses.Add(response);
                }
                
            };
            return responses;    
        }
        public void ChangeFileReaderPath(string path)
        {
            fileReader = new FileReader(path);
        }
    }
}
