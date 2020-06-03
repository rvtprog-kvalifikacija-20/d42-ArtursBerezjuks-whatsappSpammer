using System;
namespace WhatsAppSpammer
{
    public class ActivationNumber
    {
        public ActivationNumber(string number, string countryCode, DateTime createdDateTime, double price, string smsRegistrator)
        {
            Number = number;
            CountryCode = countryCode;
            CreatedDateTime = createdDateTime;
            Price = price;
            SmsRegistrator = smsRegistrator;
        }

        public ActivationNumber(string number, string countryCode, string activationCode, int messagesSent, DateTime createdDateTime, DateTime bannedDateTime, double price, string smsRegistrator)
        {
            Number = number;
            CountryCode = countryCode;
            ActivationCode = activationCode;
            MessagesSent = messagesSent;
            CreatedDateTime = createdDateTime;
            BannedDateTime = bannedDateTime;
            Price = price;
            SmsRegistrator = smsRegistrator;
        }

        [System.ComponentModel.DataAnnotations.Key]
        public string Number { get; set; }

        public string CountryCode { get; set; }

        public string ActivationCode { get; set; }

        public int? MessagesSent { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime? BannedDateTime { get; set; }

        public double? Price { get; set; }

        public string SmsRegistrator { get; set; }
    }
}
