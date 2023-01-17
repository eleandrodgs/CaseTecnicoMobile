using CaseTecnicoMobile.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoMobile.Hooks
{
    [Binding]
    public class InitilializeHook
    {       
        public AppiumDriver _appiumDriver;

        public InitilializeHook(AppiumDriver appiumDriver)
        {           
            _appiumDriver = appiumDriver;
        }

        [BeforeScenario]
        public void SetUpAndroidDriver()
        {
            _appiumDriver.InitializeAndroidDriverAppium();
        }

        [AfterScenario]
        public void TearDownAndroid()
        {
            _appiumDriver.FinishAndroidDriverAppium();
        }


    }
}
