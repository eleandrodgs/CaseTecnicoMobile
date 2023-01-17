using CaseTecnicoMobile.Helpers;
using CaseTecnicoMobile.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTecnicoMobile.Steps
{
    [Binding]
    public class CotacoesSteps
    {
        private LoginPage _loginPage;
        private Utils _utilsAppium;
        private CotacoesPage _cotacoesPage;

        public CotacoesSteps(LoginPage loginPage, Utils utilsAppium, CotacoesPage cotacoesPage)
        {
            _loginPage = loginPage;
            _utilsAppium = utilsAppium;
            _cotacoesPage = cotacoesPage;
        }

        [Given(@"que quero visualizar as cotações")]
        public void GivenQueQueroVisualizarAsCotacoes()
        {
            _utilsAppium.WaitForElement(() => _loginPage.LabelCotacoes().Displayed);            
        }

        [When(@"acesso a tela de cotações")]
        public void WhenAcessoATelaDeCotacoes()
        {
            _loginPage.AcessarCotacoes();
        }

        [Then(@"visualizo a tela de cotações")]
        public void ThenVisualizoATelaDeCotacoes()
        {
            _utilsAppium.WaitForElement(() => _cotacoesPage.TitlePage().Displayed);

            Assert.That(_cotacoesPage.ValidarItemsDoMenu(), Is.EqualTo(true));
            Assert.That(_cotacoesPage.RetornaTextoBuscarCotacoes(), Is.EqualTo("buscar cotação"));

        }

        [When(@"busco pela cotação (.*)")]
        public void GivenBuscoPorUmaCotacao(string cotacao)
        {
            _cotacoesPage.BuscaCotacao().Click();

            _utilsAppium.WaitForElement(() => _cotacoesPage.TextBuscaCotacao().Displayed);
            _cotacoesPage.TextBuscaCotacao().SendKeys(cotacao);
            _cotacoesPage.TextBuscaCotacao().SendKeys(Keys.Enter);          
        }

        [When(@"apago a cotação inserida")]
        public void WhenApagoACotacaoInserida()
        {
            _utilsAppium.WaitForElement(() => _cotacoesPage.ApagarBuscaCotacao().Displayed);
            _cotacoesPage.ApagarBuscaCotacao().Click();
        }

        [Then(@"os valores do campo de busca são apagados")]
        public void ThenOsValoresDoCampoDeBuscaSaoApagados()
        {
            Assert.That(_cotacoesPage.RetornaTextoBuscarCotacoes(), Is.EqualTo("empresa/código/índice"));
        }

        [Then(@"obtenho a mensagem de erro")]
        public void ThenObtenhoAMensagemDeErro()
        {
            _utilsAppium.WaitForElement(() => _cotacoesPage.MensagemCotacaoNaoEncontrada().Displayed);
            Assert.That(_cotacoesPage.RetornaTextoCotacaoNaoEncontrada(), Is.EqualTo("ABCD não encontrado"));
        }


    }
}
