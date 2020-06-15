using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public PhoneNumber(string number, bool? haveWhatsapp, string name, string surname, string gender)
        {
            Number = number;
            HaveWhatsapp = haveWhatsapp;
            Name = name;
            Surname = surname;
            Gender = gender;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public int NumberBaseId { get; set; }
        public string Number { get; set; }

        public bool? HaveWhatsapp { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Gender { get; set; }
    }
}
