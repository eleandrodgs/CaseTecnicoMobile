using Castle.Core.Internal;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace CaseTecnicoMobile.Drivers
{
    [Binding]
    public class AppiumDriver
    {
        private AndroidDriver<AndroidElement> _androidDriver;
        private string _profile;
        private string _device;

        public AppiumDriver(string profile, string device)
        {
            _profile = profile;
            _device = device;
        }

        public void InitializeAndroidDriverAppium()
        {
            NameValueCollection caps = ConfigurationManager.GetSection("capabilities/" + _profile) as NameValueCollection;
            NameValueCollection devices = ConfigurationManager.GetSection("environments/" + _device) as NameValueCollection;

            DesiredCapabilities capability = new DesiredCapabilities();

            foreach (string key in caps.AllKeys)
            {
                capability.SetCapability(key, caps[key]);
            }

            foreach (string key in devices.AllKeys)
            {
                capability.SetCapability(key, devices[key]);
            }

            String username = Environment.GetEnvironmentVariable("BROWSERSTACK_USERNAME");
            if (username == null)
            {
                username = ConfigurationManager.AppSettings.Get("user");
            }

            String accesskey = Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY");
            if (accesskey == null)
            {
                accesskey = ConfigurationManager.AppSettings.Get("key");
            }

            capability.SetCapability("browserstack.user", username);
            capability.SetCapability("browserstack.key", accesskey);

            String appId = Environment.GetEnvironmentVariable("BROWSERSTACK_APP_ID");
            if (appId != null)
            {
                capability.SetCapability("app", appId);
            }

            Uri uri = new Uri("http://" + ConfigurationManager.AppSettings.Get("server") + "wd/hub");
            _androidDriver = new AndroidDriver<AndroidElement>(uri, capability);

            //Uri uri = new Uri("http://" + ConfigurationManager.AppSettings.Get("server") + "wd/hub");
            //var driverOptions = new AppiumOptions();
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator");
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "C://Users//brend//Downloads//appItauCorretora.apk");            
            
            //return new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), driverOptions);
            //return new AndroidDriver<AndroidElement>(uri, driverOptions);
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
