using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace MainTest
{
    [TestFixture]
    public class TabelaNutricionalTest
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
        public void Chocolate()
        {
            //Cafeína
            PesquisarPergunta("chocolate cafeína");
            CompararResposta("43 mg");

            //Calorias
            PesquisarPergunta("chocolate calorias");
            CompararResposta("546 calorias");

            //Carboidratos
            PesquisarPergunta("chocolate carboidratos");
            CompararResposta("61 g");

            //Gordura
            PesquisarPergunta("chocolate gordura");
            CompararResposta("31 g");

            //Proteina
            PesquisarPergunta("chocolate proteinas");
            CompararResposta("4,9 g");
        }

        public void PesquisarPergunta(String pergunta)
        {
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys(pergunta + Keys.Enter);
        }

        public void CompararResposta(String resposta)
        {
            Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo(resposta));
        }
    }
}