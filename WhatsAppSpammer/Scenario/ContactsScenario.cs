using System.Collections.Generic;
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
        public static string VCardGenerator(NumberBase.NumberBase numberBase)
        {
            string vcards = "";
            var numberBases = new Dictionary<string, string>();
            foreach (var phoneNumber in numberBase.PhoneNumbers)
            {
                vcards += "BEGIN:VCARD\nVERSION:2.1\nN:;+" + phoneNumber.Number + ";;;\nFN:+" + phoneNumber.Number + "\nTEL;CELL:+" + phoneNumber.Number + "\nEND:VCARD\n"; ;
            }

            return vcards;
        }
        public static async void SendVCard(NumberBase.NumberBase numberBase)
        {
            string command = "cd " + Properties.Settings.Default.PathToSDK + "/platform-tools";
            CommandExecutor.ExecuteCommandAsync(command);
            command = " push " + " "+ numberBase.Name+ ".vcf /sdcard";
            await CommandExecutor.AdbExecutor(command);
        }

        public static async void WriteFileVCard(NumberBase.NumberBase numberBase)
        {
            
            string vCardText = await Task.Run(() => VCardGenerator(numberBase));
            await Task.Run(() =>
            {
                System.IO.File.WriteAllText(numberBase.Name+".vcf", vCardText);
            });
               
        }
    }
}
