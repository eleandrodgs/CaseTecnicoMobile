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
    public class CotacoesPage
    {
        public IMobileElement<AppiumWebElement> _androidDriver;
        private Utils _utils;
        private string _titlePageCotacoes = "//android.widget.TextView[@text='cotações']";
        private string _buscaCotacao = "//android.widget.TextView[@text='buscar cotação']";
        private string _textbuscaCotacao = "//android.widget.TextView[@text='empresa/código/índice']";
        private string _apagarBuscaCotacao = "//*[@class='android.widget.ImageView'][5]";
        private string _itemBolsas = "//android.widget.TextView[@text='bolsas']";
        private string _itemCambio = "//android.widget.TextView[@text='câmbio']";
        private string _itemAltas = "//android.widget.TextView[@text='altas']";
        private string _itemBaixas = "//android.widget.TextView[@text='bolsas']";
        private string _itemMaioresVolumes = "//android.widget.TextView[@text='maiores volumes']";
        private string _textoCotacaoNaoEncontrada = "//android.widget.TextView[@text='ABCD não encontrado']";
      
        public CotacoesPage(Utils utils, IMobileElement<AppiumWebElement> androidDriver)
        {
            _utils = utils;
            _androidDriver = androidDriver;
        }

        #region Elements
        public AppiumWebElement TitlePage()
        {
            return _androidDriver.FindElementByXPath(_titlePageCotacoes);
        }

        public AppiumWebElement BuscaCotacao()
        {
            return _androidDriver.FindElementByXPath(_buscaCotacao);
        }

        public AppiumWebElement TextBuscaCotacao()
        {
            return _androidDriver.FindElementByXPath(_textbuscaCotacao);
        }

        public AppiumWebElement ApagarBuscaCotacao()
        {
            return _androidDriver.FindElementByXPath(_apagarBuscaCotacao);
        }

        public AppiumWebElement ItemBolsas()
        {
            return _androidDriver.FindElementByXPath(_itemBolsas);
        }

        public AppiumWebElement ItemCambio()
        {
            return _androidDriver.FindElementByXPath(_itemCambio);
        }

        public AppiumWebElement ItemAltas()
        {
            return _androidDriver.FindElementByXPath(_itemAltas);
        }

        public AppiumWebElement ItemBaixas()
        {
            return _androidDriver.FindElementByXPath(_itemBaixas);
        }

        public AppiumWebElement ItemMaioresVolumes()
        {
            return _androidDriver.FindElementByXPath(_itemMaioresVolumes);
        }

        public AppiumWebElement MensagemCotacaoNaoEncontrada()
        {
            return _androidDriver.FindElementByXPath(_textoCotacaoNaoEncontrada);
        }

        #endregion     

        public bool ValidarItemsDoMenu()
        {
            return (ItemBaixas().Displayed && ItemBolsas().Displayed &&
                ItemCambio().Displayed && ItemAltas().Displayed &&
                ItemBaixas().Displayed && ItemMaioresVolumes().Displayed
                && BuscaCotacao().Displayed);
        }

        public string RetornaTextoBuscarCotacoes()
        {
            return TextBuscaCotacao().Text;          
        }

        public string RetornaTextoCotacaoNaoEncontrada()
        {
            return MensagemCotacaoNaoEncontrada().Text;
        }

    }
}
