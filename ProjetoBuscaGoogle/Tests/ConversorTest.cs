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
        public void RealParaEuro()
        {
            driver.FindElement(By.Name("q")).SendKeys("100 brl to eur");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".vLqKYe:nth-child(2)")).Text, Is.EqualTo("Real brasileiro"));
            Assert.That(driver.FindElement(By.CssSelector(".nGP2Tb")).Text, Is.EqualTo("Euro"));
        }
        
        [Test]
        public void RealParaDolar()
        {
            driver.FindElement(By.Name("q")).SendKeys("100 brl to usd");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".vLqKYe:nth-child(2)")).Text, Is.EqualTo("Real brasileiro"));
            Assert.That(driver.FindElement(By.CssSelector(".nGP2Tb")).Text, Is.EqualTo("Dólar americano"));
        }

        [Test]
        public void DolarParaEuro()
        {
            driver.FindElement(By.Name("q")).SendKeys("100 usd to eur");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".vLqKYe:nth-child(2)")).Text, Is.EqualTo("Dólar americano"));
            Assert.That(driver.FindElement(By.CssSelector(".nGP2Tb")).Text, Is.EqualTo("Euro"));
        }

        [Test]
        public void EuroParaDolar()
        {
            driver.FindElement(By.Name("q")).SendKeys("100 eur to usd");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".vLqKYe:nth-child(2)")).Text, Is.EqualTo("Euro"));
            Assert.That(driver.FindElement(By.CssSelector(".nGP2Tb")).Text, Is.EqualTo("Dólar americano"));
        }
}
