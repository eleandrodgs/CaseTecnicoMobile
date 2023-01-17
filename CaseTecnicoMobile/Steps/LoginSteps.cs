using CaseTecnicoMobile.Helpers;
using CaseTecnicoMobile.Pages;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace CaseTecnicoMobile.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage _loginPage;
        private Utils _utilsAppium;

        public LoginSteps(LoginPage loginPage, Utils utilsAppium)
        {          
            _loginPage = loginPage;
            _utilsAppium = utilsAppium;
        }

        [Given(@"que preciso fazer login no aplicativo")]
        public void GivenQuePrecisoFazerLoginNoAplicativo()
        {
            _utilsAppium.WaitForElement(() => _loginPage.TextConta().Displayed);
        }

        [Given(@"insiro as credenciais inválidas")]
        public void GivenInsiroAsCredenciaisInvalidas()
        {
            _loginPage.InserirAgencia("0011");
            _loginPage.InserirConta("325011");
            _loginPage.InserirSenha("11223344");
        }

        [When(@"clico no botão de login")]
        public void WhenClicoNoBotaoDeLogin()
        {
            _loginPage.AcessarConta();
        }

        [Then(@"obtenho o erro")]
        public void ThenObtenhoOErro()
        {
            _utilsAppium.WaitForElement(() => _loginPage.LabelErroTratamento().Displayed);
            _utilsAppium.WaitForElement(() => _loginPage.BtnOkEntendi().Displayed);
        }

    }
}