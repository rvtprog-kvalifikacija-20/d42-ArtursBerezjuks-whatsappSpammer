using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using WhatsAppSpammer.NumberBase;

namespace WhatsAppSpammer.DeviceController
{
    public class DeviceController
    {
        public string DeviceName { get; set; }
        
        public string Proxy { get; set; }
        
        public NumberBase.NumberBase NumberBase { get; set; }

        public AbstractSmsRegistrator SmsRegistrator { get; set; }

        public DeviceController(string deviceName, string proxy)
        {
            DeviceName = deviceName;
            Proxy = proxy;
        }
        public void Wait(int ms)
        {
            Thread.Sleep(ms);
        }
        public void RunEmulator()
        {
            string command = "emulator @" + DeviceName;
            if (Proxy != "" && Proxy != null)
            {
                command += " -http-proxy " + Proxy;
            }
            command += " -wipe-data -no-snapshot-load";

            CommandExecutor.ExecuteCommandAsync(command);
        }

    }
}
