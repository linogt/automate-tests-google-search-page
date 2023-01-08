using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace MainTest
{

    [TestFixture]
    public class ConversorTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Moedas()
        {
            //USD PARA BRL
            PesquisarPergunta("100 usd to brl");
            CompararResposta("Dólar americano", "Real brasileiro");

            //BRL PARA USD
            PesquisarPergunta("100 brl to usd");
            CompararResposta("Real brasileiro", "Dólar americano");

            //BRL PARA EUR
            PesquisarPergunta("100 brl to eur");
            CompararResposta("Real brasileiro", "Euro");

            //USD PARA EUR
            PesquisarPergunta("100 usd to eur");
            CompararResposta("Dólar americano", "Euro");

            //EUR PARA BRL
            PesquisarPergunta("100 eur to brl");
            CompararResposta("Euro", "Real brasileiro");

            //EUR PARA USD
            PesquisarPergunta("100 eur to usd");
            CompararResposta("Euro", "Dólar americano");

        }

        public void PesquisarPergunta(String pergunta)
        {
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys(pergunta + Keys.Enter);
        }

        public void CompararResposta(String moeda1, String moeda2)
        {
            Assert.That(driver.FindElement(By.CssSelector(".vLqKYe:nth-child(2)")).Text, Is.EqualTo(moeda1));
            Assert.That(driver.FindElement(By.CssSelector(".nGP2Tb")).Text, Is.EqualTo(moeda2));
        }
    }
}