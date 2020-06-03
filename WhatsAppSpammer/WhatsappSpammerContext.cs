using System.Data.Entity;
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
