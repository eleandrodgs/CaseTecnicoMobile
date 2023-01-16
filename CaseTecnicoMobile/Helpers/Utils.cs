using LivingDoc.Dtos;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
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
        //public AndroidDriver<AndroidElement> _androidDriver { get; set; }
        //public AndroidElement _androidElement;
        //public TimeSpan _time = TimeSpan.FromSeconds(5000);

        //public void WaitForElement(By element)
        //{
        //    try
        //    {
        //        new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"Wait For Element {element} Failed: {e.Message}");
        //    }
        //}

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
