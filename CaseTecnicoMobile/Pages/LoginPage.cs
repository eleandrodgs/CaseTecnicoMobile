using CaseTecnicoMobile.Drivers;
using CaseTecnicoMobile.Helpers;
using Dynamitey;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.BindingSkeletons;

namespace CaseTecnicoMobile.Pages
{
    [Binding]
    public class LoginPage
    {
        public IMobileElement<AppiumWebElement> _androidDriver;
        private Utils _utils;
        private string _btnAcessar = "//android.widget.Image[@text='acessar']";
        private string _textAgencia = "//android.widget.EditText[@text='agência']";
        private string _txtConta = "//android.widget.EditText[@text='conta']";
        private string _textPwd = "//android.widget.EditText[@text='senha eletrônica']";
        private string _lblCotacoes = "//android.widget.TextView[@text='cotações']";
        private string _lblErroTratamento = "android:id/message";
        private string _btnOkEntendi = "android:id/button1";

        public LoginPage(Utils utils, IMobileElement<AppiumWebElement> androidDriver)
        {
            _utils = utils;
            _androidDriver = androidDriver;
        }

        #region Elements
        public AppiumWebElement TxtAgencia()
        {
            return _androidDriver.FindElementByXPath(_textAgencia);
        }

        public AppiumWebElement TextConta()
        {
            return _androidDriver.FindElementByXPath(_txtConta);
        }

        public AppiumWebElement TextSenha()
        {
            return _androidDriver.FindElementByXPath(_textPwd);
        }
        public AppiumWebElement BtnAcessar()
        {
            return _androidDriver.FindElementByXPath(_btnAcessar);
        }

        public AppiumWebElement LabelCotacoes()
        {
            return _androidDriver.FindElementByXPath(_lblCotacoes);
        }
        public AppiumWebElement LabelErroTratamento()
        {
            return _androidDriver.FindElementById(_lblErroTratamento);
        }

        public AppiumWebElement BtnOkEntendi()
        {
            return _androidDriver.FindElementById(_btnOkEntendi);
        }

        #endregion

        public void InserirAgencia(string agencia)
        {
            TxtAgencia().SendKeys(agencia);
        }

        public void InserirConta(string conta)
        {
            TextConta().SendKeys(conta);
        }

        public void InserirSenha(string senha)
        {
            TextSenha().SendKeys(senha);
        }    

        public void AcessarConta()
        {
            BtnAcessar().Click();
        }  
        
        public void AcessarCotacoes()
        {
            LabelCotacoes().Click();
        }

        //mapear notificação de erro no login
     
    }
}
