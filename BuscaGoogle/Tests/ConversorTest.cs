using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

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

            ChromeOptions cap_chrome = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap_chrome);
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
            Thread.Sleep(3000);
        }

        public void CompararResposta(String moeda1, String moeda2)
        {
            Assert.That(driver.FindElement(By.CssSelector(".vLqKYe:nth-child(2)")).Text, Is.EqualTo(moeda1));
            Assert.That(driver.FindElement(By.CssSelector(".nGP2Tb")).Text, Is.EqualTo(moeda2));
        }
    }
}