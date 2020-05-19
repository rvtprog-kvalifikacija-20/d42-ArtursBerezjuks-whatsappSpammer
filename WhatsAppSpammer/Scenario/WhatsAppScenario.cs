using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WhatsAppSpammer 
{ 
    public static class WhatsAppScenario
    {
        public static async Task<bool> Registration(AppiumDevice ap, string phone, string cc)
        {

            Logger.log("Inputing number");
            Random random = new Random();
            var el1 =  ap.GetElementByID("com.whatsapp:id/eula_accept");
            await Task.Delay(random.Next(1000, 2000));
            el1.Click();

            var el2 = ap.GetElementByID("com.whatsapp:id/registration_cc");
            el2.Clear();
            el2.SendKeys(cc);
            await Task.Delay(random.Next(1000, 2000));
            var el3 = ap.GetElementByID("com.whatsapp:id/registration_phone");
            el3.SendKeys(phone);

            var el4 = ap.GetElementByID("com.whatsapp:id/registration_submit");
            el4.Click();
            await Task.Delay(random.Next(1000, 2000));
            int iterations = 0;
            bool banned = false;
            while (iterations < 60)
            { 
                try
                {
                    
                    var el5 = ap.GetElementByID("android:id/button1");
                    var message = ap.GetElementByID("android:id/message");
                    if (message.Text.Contains("banned"))
                    {
                        banned = true;
                        Logger.log("Number " + phone + " banned");
                        break;
                    }
                    
                    el5.Click();
                    break;
                }
                catch
                {
                    iterations++; 
                    await Task.Delay(10000);
                }           
            }
            Logger.log("Waiting for code");
            return banned;
        }
        public static void VerifyCode(AppiumDevice ap, string code)
        {
            Logger.log("Recived code: " + code);
            var el6 = ap.GetElementByID("com.whatsapp:id/verify_sms_code_input");
            el6.SendKeys(code);     
        }
        public static void WriteName(AppiumDevice ap, string name)
        {

            Logger.log("Writing name " + name);
            var el1 = ap.GetElementByID("com.whatsapp:id/registration_name");
            el1.SendKeys(name);
            var el2 = ap.GetElementByID("com.whatsapp:id/register_name_accept");
            el2.Click();
            var el3 = ap.GetElementByID("com.whatsapp:id/instruction_badge");
            el3.Click();
        }
        public static async void WriteMessage(AppiumDevice ap, string number,string text)
        {

            Logger.log("New message to: " + number) ;
            int iterations = 0;
            while (iterations < 20)
            {
                try
                {
                    var el17 = ap.GetElementByAccessibilityID("Search");
                    el17.Click();
                    break;
                }
                catch
                {
                    iterations++;
                    await Task.Delay(1000);
                }
            }
           iterations = 0;
            while (iterations < 20)
            {
                try
                {
                    var el19 = ap.GetElementByID("com.whatsapp:id/search_src_text");
                    el19.SendKeys(number);
                    break;
                }
                catch
                {
                    iterations++;
                    await Task.Delay(1000);
                }
            }
           
            iterations = 0;
            while (iterations < 25)
            {
                try
                {
                    var el20 = ap.GetElementByXpath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout[1]/androidx.viewpager.widget.ViewPager/android.widget.LinearLayout/android.widget.ListView/android.widget.RelativeLayout[1]");
                    el20.Click();
                    break;
                }
                catch
                {
                    iterations++;
                    await Task.Delay(1000);
                }
            }
            while (iterations < 20)
            {
                try
                {
                    var el21 = ap.GetElementByID("com.whatsapp:id/entry");
                    el21.SendKeys(text);
                    break;
                }
                catch
                {
                    iterations++;
                    await Task.Delay(1000);
                }
            }
            while (iterations < 20)
            {
                try
                {
                    var el22 = ap.GetElementByAccessibilityID("Send");
                    el22.Click();

                    Logger.log("Message sent");
                    break;
                }
                catch
                {
                    iterations++;
                    await Task.Delay(1000);
                }
            }
            ap.Back();
        }

    }
}
