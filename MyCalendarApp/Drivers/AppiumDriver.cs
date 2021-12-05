using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace MyCalendarApp.Drivers
{
    class AppiumDriver
    {
        private AppiumDriver<AndroidElement> _driver;

        public AppiumDriver<AndroidElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10.0");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel4");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\Irina Koida\\Downloads\\Fossil-Explorer-2-0-1.apk");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "Appium");

            var appiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1")
                .UsingAnyFreePort().Build(); //запускаем сервер

            if (!appiumService.IsRunning)
            {
                appiumService.Start();
            }

            _driver = new AndroidDriver<AndroidElement>(appiumService, driverOptions, TimeSpan.FromSeconds(100));
            // _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), driverOptions, TimeSpan.FromSeconds(100));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return _driver;

        }
    }
}
