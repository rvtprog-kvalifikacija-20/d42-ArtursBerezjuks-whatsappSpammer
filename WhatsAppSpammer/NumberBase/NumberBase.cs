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
        public int Id { get; set; }

        public ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public int MessageId { get; set;  }

        public Message Message { get; set; }
    }
}
