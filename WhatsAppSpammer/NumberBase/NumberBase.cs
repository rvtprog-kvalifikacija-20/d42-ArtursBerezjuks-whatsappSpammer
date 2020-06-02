using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppSpammer.Numbers;

namespace WhatsAppSpammer.NumberBase
{
    public class NumberBase 
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }

        public int MessageId { get; set;  }

        public Message Message { get; set; }
        public NumberBase()
        {

        }
        public NumberBase(string name, List<PhoneNumber> phoneNumbers, Message message)
        {
            Name = name;
            PhoneNumbers = phoneNumbers;
            Message = message;
        }
    }
}
