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
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11.0");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "C://Users//brend//Downloads//appItauCorretora.apk");            

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
