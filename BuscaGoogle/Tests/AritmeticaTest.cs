using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace MainTest
{


    [TestFixture]
    public class AritmeticaTest
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
        public void Contas()
        {   //Soma
            PesquisarPergunta("0+0");
            CompararResposta("0");
            //Soma
            PesquisarPergunta("2+2");
            CompararResposta("4");
            //Subtra��o
            PesquisarPergunta("2-2");
            CompararResposta("0");
            //Multiplica��o
            PesquisarPergunta("2*2");
            CompararResposta("4");
            //Divis�o
            PesquisarPergunta("2/2");
            CompararResposta("1");
            //Potencia��o
            PesquisarPergunta("2^2");
            CompararResposta("4");
            //Multiplica��o
            PesquisarPergunta("2*10");
            CompararResposta("20");
            //Subtra��o
            PesquisarPergunta("20-50");
            CompararResposta("-30");
            //Subtra��o
            PesquisarPergunta("-2-2");
            CompararResposta("-4");
            //Soma
            PesquisarPergunta("10+10");
            CompararResposta("20");

        }



        public void PesquisarPergunta(String pergunta)
        {
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys(pergunta + Keys.Enter);
        }

        public void CompararResposta(String resposta)
        {
            Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo(resposta));
        }

    }
}