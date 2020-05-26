using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace WhatsAppSpammer
{
    public class ActivationNumberContext : DbContext
    {
       public DbSet<ActivationNumber> ActivationNumbers { get; set; }
    }
}
