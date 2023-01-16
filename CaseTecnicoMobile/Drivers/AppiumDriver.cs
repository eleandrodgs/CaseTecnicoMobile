using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoMobile.Drivers
{
    [Binding]
    public class AppiumDriver
    {
        private AndroidDriver<AndroidElement> _androidDriver { get; set; }

        public AndroidDriver<AndroidElement> InitializeAndroidDriverAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "4 WVGA (Nesus S) API 30");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "");


            return new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), driverOptions);
        }

        public void FinishAndroidDriverAppium()
        {
            if (_androidDriver != null)
            {
                _androidDriver.Quit();
            }
        }
    }
}
