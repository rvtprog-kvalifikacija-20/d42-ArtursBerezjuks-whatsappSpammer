using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsappSpammer;

namespace WhatsAppSpammer.SmsRegistrator
{
    ///<summary>
    ///Save numbers as json
    ///</summary>
    class ActivationNumberBaseRepository
    {
       

        public bool Save(string name)
        {
            return true;
        }
        public string Add(string number)
        {
            return "";
        }
        public bool Delete(string name)
        {
            return true;
        }

        public NumberBase GetNumberBase()
        {
            return new NumberBase(new List<string>());
        }
    }
}
