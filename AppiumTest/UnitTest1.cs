using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace AppiumTest
{
    public class Tests
    {
        AndroidDriver<AndroidElement> driver;
        [SetUp]
        public void Setup()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "7.1.1");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android Device");
            capabilities.SetCapability("appPackage", "com.instagram.android");
            capabilities.SetCapability("appActivity", "com.instagram.android.activity.MainTabActivity");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/"), capabilities);


        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}