using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Enums;
using System.IO;

namespace WhatsAppSpammer
{
    public class AppiumDevice
    {
        public AndroidDriver<AndroidElement> driver;
        public Device Device { get; set; }
       
        public string Port { get; set; }
       
        public AppiumDevice(App app, string appActivity, Device device)
        {
            this.Device = device;
            DesiredCapabilities capabilities = new DesiredCapabilities();
            
            capabilities.SetCapability(MobileCapabilityType.PlatformName, device.Platform);
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, device.Version);
            capabilities.SetCapability(MobileCapabilityType.DeviceName, device.Name);
            capabilities.SetCapability(MobileCapabilityType.App,app.AppPath);
            capabilities.SetCapability(MobileCapabilityType.AutomationName, Properties.Settings.Default.AutomationName);
            capabilities.SetCapability(MobileCapabilityType.NewCommandTimeout, 0);
            capabilities.SetCapability(MobileCapabilityType.NoReset, true);
            capabilities.SetCapability("unicodeKeyboard", true);
            capabilities.SetCapability("resetKeyboard", true);
            capabilities.SetCapability("appPackage", app.AppPackage);
            capabilities.SetCapability("appActivity", appActivity);
            capabilities.SetCapability("newCommandTimeout", 0);
            capabilities.SetCapability("avdLaunchTimeout", 600000);

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
        }
        public AppiumDevice(App app, string appActivity, Device device, string port)
        {
            this.Device = device;
            DesiredCapabilities capabilities = new DesiredCapabilities();

            capabilities.SetCapability(MobileCapabilityType.PlatformName, device.Platform);
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, device.Version);
            capabilities.SetCapability(MobileCapabilityType.DeviceName, device.Name);
            capabilities.SetCapability(MobileCapabilityType.App, app.AppPath);
            capabilities.SetCapability(MobileCapabilityType.AutomationName, Properties.Settings.Default.AutomationName);
            capabilities.SetCapability(MobileCapabilityType.NewCommandTimeout, 0);
            capabilities.SetCapability(MobileCapabilityType.NoReset, true);
            capabilities.SetCapability("unicodeKeyboard", true);
            capabilities.SetCapability("resetKeyboard", true);
            capabilities.SetCapability("appPackage", app.AppPackage);
            capabilities.SetCapability("appActivity", appActivity);
            capabilities.SetCapability("newCommandTimeout", 0);
            capabilities.SetCapability("avdLaunchTimeout", 600000);

            Port = port;
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:"+port+"/wd/hub"), capabilities);
            //driver.StartActivity(app.AppPackage, appActivity);
        }
        public AndroidElement GetElementByText(string text)
        {
            var elementsList = driver.FindElementsByXPath("//*");
            foreach (var element in elementsList)
            {
                if (element.Text.Contains(text))
                {
                    return element;
                }
            }
            return null;
        }
        public AndroidElement GetElementByID(string id)
        {
            return driver.FindElementById(id);
        }
        public AndroidElement GetElementByAccessibilityID(string id)
        {
            return driver.FindElementByAccessibilityId(id);
        }
        public AndroidElement GetElementByXpath(string xpath)
        {
            return driver.FindElementByXPath(xpath);
        }
        public void Back()
        {
            driver.Navigate().Back();
        }
        public void Click(string text)
        {
            
            AndroidElement el = driver.FindElement(MobileBy.Id(GetElementByText(text).Id));
            el.Tap(1, 10);
        }
        public void SendText(string sendText, string text)
        {
            GetElementByText(text).SendKeys(sendText);
        }
        public void CloseApp()
        {
            driver.CloseApp();
        }
        public string GetCurrentActivity()
        {
            return driver.CurrentActivity;
        }

    }
}
