using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;

namespace Appium
{
    public class Tests
    {
        AndroidDriver<AndroidElement> driver;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "9.0");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "phone_1");
            capabilities.SetCapability(MobileCapabilityType.App, "C:\\whatsapp\\com.whatsapp.apk");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
  
            Assert.Pass();
        }
    }
}