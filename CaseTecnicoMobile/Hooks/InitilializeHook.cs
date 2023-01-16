using CaseTecnicoMobile.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoMobile.Hooks
{
    [Binding]
    public sealed class InitilializeHook
    {       
        private AppiumDriver _appiumDriver;

        public InitilializeHook(AppiumDriver appiumDriver)
        {           
            _appiumDriver = appiumDriver;
        }

        [BeforeTestRun]
        public void SetUpAndroidDriver()
        {
            _appiumDriver.InitializeAndroidDriverAppium();
        }

        [AfterTestRun]
        public void TearDownAndroid()
        {
            _appiumDriver.FinishAndroidDriverAppium();
        }


    }
}
