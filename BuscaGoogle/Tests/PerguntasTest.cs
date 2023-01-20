using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace MainTest
{
    [TestFixture]
    public class PerguntasTest
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
            driver.Navigate().GoToUrl("https://www.google.com.br/");
        }


        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }


        [Test]
        public void Perguntas()

        {   //Beatles
            PesquisarPergunta("Ano do fim dos Beatles");
            CompararResposta("1970");

            //Coca-Cola
            PesquisarPergunta("Ano e local que a Coca Cola foi fundada");
            CompararResposta("1892, Atlanta, Geórgia, EUA");

            //Clube da Luta
            PesquisarPergunta("Ano de lançamento do filme Clube da Luta");
            CompararResposta("29 de outubro de 1999");

            //Corinthians
            PesquisarPergunta("Data em que o Corinthians foi fundado");
            CompararResposta("1910");

            //Jujutsu Kaisen
            PesquisarPergunta("Nome do protagonista de Jujutsu Kaisen");
            CompararResposta("Yuji Itadori");

            //Grecia
            PesquisarPergunta("Qual continente fica a Grecia");
            CompararResposta("Europa");

            //Marvel
            PesquisarPergunta("Fundador da Marvel");
            CompararResposta("Martin Goodman");

            //Japão
            PesquisarPergunta("Qual é a capital do Japão?");
            CompararResposta("Tóquio");

            //Astronauta Lua
            PesquisarPergunta("qual é o primeiro astronauta a pisar na lua");
            Assert.That(driver.FindElement(By.CssSelector("#rso > div:nth-child(2) > div > block-component > div > div.dG2XIf.XzTjhb > div > div > div > div > div.ifM9O > div > div > div > div > div.wDYxhc > div > span.ILfuVd > span > b")).Text, Is.EqualTo("Neil Armstrong"));


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