using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
