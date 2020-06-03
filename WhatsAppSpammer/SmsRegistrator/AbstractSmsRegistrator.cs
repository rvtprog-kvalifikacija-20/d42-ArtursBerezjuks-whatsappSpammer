using System.Threading.Tasks;

namespace WhatsAppSpammer
{
    public abstract class AbstractSmsRegistrator
    {
        public AbstractSmsRegistrator(string apiKey, string referal, string counrty)
        {
            ApiKey = apiKey;
            Referal = referal;
            Country = counrty;
        }
        public AbstractSmsRegistrator()
        {
            ApiKey = Properties.Settings.Default.ApiKey;
            Referal = Properties.Settings.Default.Referal;
            Country = Properties.Settings.Default.Country;
        }
        public string BaseUrl { get; set; }

        public string ApiKey { get; set; }

        public string Referal { get; set; }

        public string Country { get; set; }

        public abstract Task<string> GetNumber();

        public abstract void PhoneReady(string phone);

        public abstract Task<string> GetCode(string phone);

        public abstract void SetStatus(string phone, string statusCode);
    }
}
