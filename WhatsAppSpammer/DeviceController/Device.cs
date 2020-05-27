using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSpammer
{
    public class Device
    {
        public string ID { get; set; }

        public string Platform { get; set; }

        public string Version { get; set; }

        public string Name { get; set; }

        public Device(Device device)
        {
            ID = device.ID;
            Platform = device.Platform;
            Version = device.Version;
            Name = device.Name;
        }
        public Device(string deviceName)
        {
            string[] device = deviceName.Split('_');
            ID = device[0];
            Platform = device[1];
            Version = device[2];
            Name = deviceName;
        }

        public string GetActivity()
        {
           return CommandExecutor.ExecuteCommandSync("adb shell dumpsys window windows | grep -E 'mCurrentFocus|mFocusedApp'");
        }


    }
}
