using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSpammer
{
    public class App
    {
        public string AppPath { get; set; }
        public string AppPackage { get; set; }
        public App(string appPath, string appPackage)
        {
            AppPath = appPath;
            AppPackage = appPackage;
        }

    }
    public static class Apps   
    {
        public static App WhatsApp = new App("C:\\Program Files (x86)\\Android\\android-sdk\\platform-tools\\WhatsApp.apk", "com.whatsapp");
        public static App Contacts = new App("C:\\Program Files (x86)\\Android\\android-sdk\\platform-tools\\com.kitkatandroid.contacts.com.apk", "com.android.contacts");
        public static string WhatsAppActivity_Main = "com.whatsapp.Main";
        public static string ContatsActivity_Main = ".activities.PeopleActivity";
        public static string WhatsAppActivity_Eula = "com.whatsapp.registration.EULA";
        public static string WhatsAppActivity_Home = "com.whatsapp.HomeActivity"; 
        public static string WhatsAppAcceptEulaId= "com.whatsapp:id/eula_accept";
        public static string WhatsAppAcceptEulaXpath= "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.Button";
        public static string WhatsAppActivity3 = "";
        public static string WhatsAppActivity4 = "";
        
        // new List<string>() { ".activities.PeopleActivity"});

        //registration
        //com.whatsapp:id/eula_accept 
        //com.whatsapp:id/registration_phone
        //com.whatsapp:id/registration_submit
        //com.whatsapp:id/registration_cc
        //	android:id/button1
        //com.whatsapp:id/verify_sms_code_input
    }
}
