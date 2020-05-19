using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSpammer
{
    class ActivationNumber
    {
        public string Number { get; set; }

        public string CountryCode { get; set; }

        public string ActivationCode { get; set; }

        public int MessagesSent { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime BannedDateTime { get; set; }

        public double Price { get; set; }

        public string SmsRegistrator { get; set; }
    }
}
