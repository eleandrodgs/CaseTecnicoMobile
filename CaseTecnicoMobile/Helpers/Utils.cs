using CaseTecnicoMobile.Drivers;
using LivingDoc.Dtos;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoMobile.Helpers
{
    [Binding]
    public class Utils
    {
        public AndroidDriver<AppiumWebElement> _androidDriver { get; set; }
        public AndroidElement _androidElement;
        public WebDriverWait _waitDriver;
        
        public void WaitForElement(Func<bool> condition)
        {
            try
            {
                _waitDriver = new WebDriverWait(_androidDriver, TimeSpan.FromSeconds(10));
                _waitDriver.Until(driver => EvaluateConditionWithoutThrowing(condition));

            }
            catch (WebDriverTimeoutException)
            {
                // Force same exception
                condition();
            }
        }

        private static bool EvaluateConditionWithoutThrowing(Func<bool> condition)
        {
            try
            {
                return condition();
            }
            catch
            {
                return false;
            }
        }

        //public Utils WaitClickable()
        //{
        //   // new WebDriverWait(_androidDriver, _time).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locator)));
        //    return this;
        //}

        //public Utils FindElement(string locator)
        //{
        //    WaitVisible();
        //    _androidElement = _androidDriver.FindElement(By.Id(locator));
        //    return this;
        //}

        //public Utils Click(By element)
        //{
        //    WaitForElement(element);

        //    try
        //    {
        //        GetDriver().FindElement(element).Click();
        //        Report.test.Info($"Clicked on element {element}");
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"Failed to click on the element: {element}. {e.Message}");
        //    }
        //    _androidElement.Click();
        //    return this;
        //}

        //public Utils SendKeys(string keysToSend)
        //{
        //    WaitClickable();
        //    _androidElement.SendKeys(keysToSend);
        //    return this;
        //}

        //public string Text()
        //{
        //    return _androidElement.Text;
        //}

        //public void ValidateByID(string ID)
        //{
        //    FindElement(ID);
        //}
    }    
}
