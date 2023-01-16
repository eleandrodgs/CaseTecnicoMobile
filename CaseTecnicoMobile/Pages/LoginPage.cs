using CaseTecnicoMobile.Helpers;
using Dynamitey;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.BindingSkeletons;

namespace CaseTecnicoMobile.Pages
{
    [Binding]
    public class LoginPage
    {
        public AndroidDriver<AndroidElement> _androidDriver { get; set; }
        private Utils _utils;
        private string _btnAcessar = "idBotaoAcessar";
        private string _textAgencia = "//android.widget.TextView[@text='agência']";
        private string _txtConta = "//android.widget.TextView[@text='agência']";
        private string _textPwd = "idPassword";
        private string _btnCotacoes = "idCotacoes";

        public LoginPage(Utils utils)
        {
            _utils = utils;
        } 

        public AndroidElement TxtAgencia()
        {
            return _androidDriver.FindElement(By.XPath(_textAgencia));
        }

        public AndroidElement TextConta()
        {
            return _androidDriver.FindElement(By.XPath(_txtConta));
        }

        public void InserirAgencia(string agencia)
        {
            TxtAgencia().SendKeys(agencia);
        }

        public void InserirConta(string conta)
        {
            TextConta().SendKeys(conta);
        }

        //public void InserirSenha(string senha)
        //{
        //    _utils.FindElement(_textPwd).SendKeys(senha);
        //}

        public void AcessarConta()
        {
            //_utils.FindElement(_btnAcessar).Click();
        }    

        //mapear notificação de erro no login
     
    }
}
