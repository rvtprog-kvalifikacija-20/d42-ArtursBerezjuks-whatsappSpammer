using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppSpammer.NumberBase;
using WhatsAppSpammer.Numbers;

namespace WhatsAppSpammer
{        
    public class WhatsappSpammerContext : DbContext
    {
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<ActivationNumber> ActivationNumbers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<NumberBase.NumberBase> NumberBase { get; set; }
    }
}
