using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSpammer.Numbers
{
    public class PhoneNumber
    {
        public PhoneNumber()
        {
            Number = String.Empty;
            HaveWhatsapp = null;
            Name = String.Empty;
            Surname = String.Empty;
            Gender = String.Empty;
        }

        public PhoneNumber(string number, bool? haveWhatsapp, string name, string surname, string gender )
        {
            Number = number;
            HaveWhatsapp = haveWhatsapp;
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public string Number { get; set; }
        
        public bool? HaveWhatsapp { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Gender { get; set; }
    }
}
