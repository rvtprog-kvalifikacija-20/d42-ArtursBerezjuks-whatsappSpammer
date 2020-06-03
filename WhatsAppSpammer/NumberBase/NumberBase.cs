using System.Collections.Generic;
using WhatsAppSpammer.Numbers;

namespace WhatsAppSpammer.NumberBase
{
    public class NumberBase
    {
        [System.ComponentModel.DataAnnotations.Key]

        public string Name { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }

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
