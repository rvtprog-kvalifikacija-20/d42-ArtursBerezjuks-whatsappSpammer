using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsAppSpammer
{
    public static class ContactsScenario
    {
        public static void ImportContacts(AppiumDevice ap)
        {
            var el1 = ap.GetElementByID("com.google.android.gsf.login:id/skip_button");
            el1.Click();
            var el2 = ap.GetElementByID("com.android.contacts:id/import_contacts_button");
            el2.Click();
            var el3 = ap.GetElementByXpath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.ListView/android.widget.TextView[2]");
            el3.Click();
        }

        public static async void GenerateVCard(DeviceController.DeviceController device)
        {
            var phoneNumbers = device.DB.PhoneNumbers.Where(p => p.NumberBaseId == device.NumberBase.Id).ToList();
            var pathToExe = System.Reflection.Assembly.GetEntryAssembly().Location.Split('\\');
            string path = string.Join("\\" , pathToExe.Take(pathToExe.Count() - 1).ToArray()); 
            string filename = path + "\\" + device.NumberBase.Name + ".vcf";
            string vcf = "";
            foreach (var phoneNumber in phoneNumbers)
            {
                vcf += "BEGIN:VCARD\nVERSION:2.1\nN:;+" + phoneNumber.Number + ";;;\nFN:+" + phoneNumber.Number + "\nTEL;CELL:+" + phoneNumber.Number + "\nEND:VCARD\n";
            }

            if (!File.Exists(filename))
            {
                File.Create(filename);
            }

            System.IO.File.WriteAllText(filename, vcf);
            string command = "cd " + Properties.Settings.Default.PathToSDK + "\\platform-tools";
            CommandExecutor.ExecuteCommandAsync(command);
            command = " push " + filename + " /sdcard";
            CommandExecutor.AdbExecutor(command);
            device.AppiumDevice.driver.PushFile("/sdcard", new FileInfo(device.NumberBase.Name + ".vcf"));
        }
    }
}
