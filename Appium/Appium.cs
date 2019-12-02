using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Enums;
using System.IO;

namespace WhatsAppSpammer
{
    class Appium
    {
        AndroidDriver<AndroidElement> driver;
        [Obsolete]
        public Appium()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "9.0");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "phone_1");
            capabilities.SetCapability(MobileCapabilityType.App, "C:\\whatsapp\\com.whatsapp.apk");
                
                    driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            driver.FindElementById("com.whatsapp:id/eula_accept").Click();
            driver.CloseApp();
        }
    }
}
