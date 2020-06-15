using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WhatsAppSpammer.Numbers;

namespace WhatsAppSpammer.NumberBase
{
    public class NumberBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Numbers.PhoneNumber> PhoneNumbers { get; set; }

        [ForeignKey("FK_PhoneNumberIds")]
        public  List<int> PhoneNumberIds { get; set; }

        public Message Message { get; set; }
        public NumberBase()
        {

        }
        public NumberBase(string name, List<PhoneNumber> phoneNumbers, Message message)
        {
            Name = name;
            this.PhoneNumbers = phoneNumbers;
            PhoneNumberIds = new List<int>();
            phoneNumbers.ForEach(p=> {
                p.NumberBaseId = this.Id;
                PhoneNumberIds.Add(p.Id);
              
            });
            Message = message;
        }
        
    }
}
