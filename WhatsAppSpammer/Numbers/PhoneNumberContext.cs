using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSpammer.Numbers
{
    public class PhoneNumberContext : DbContext
    {
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}
