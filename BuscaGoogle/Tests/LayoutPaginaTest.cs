using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace MainTest
{
    [TestFixture]
    public class LayoutPaginaTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Close();
            driver.Quit();
        }



        [Test]
        public void Layout()
        {
            //Caixa de busca
            Assert.True(driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div")).Displayed);
            //Botão "Pesquisa Google"
            Assert.True(driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Displayed);
            //Botão "Estou com Sorte"
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[2]")).Displayed);
            //Sobre
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[1]")).Text, Is.EqualTo("Sobre"));
            //Publicidade
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[2]")).Text, Is.EqualTo("Publicidade"));
            //Negocíos
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[3]")).Text, Is.EqualTo("Negócios"));
            //Como Funciona a Pesquisa
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[4]")).Text, Is.EqualTo("Como funciona a Pesquisa"));
            //Privacidade
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[2]/a[1]")).Text, Is.EqualTo("Privacidade"));
            //Termos
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[2]/a[2]")).Text, Is.EqualTo("Termos"));
            //Configurações
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[2]/span/span/g-popup/div[1]/div")).Text, Is.EqualTo("Configurações"));
        }
    }
}