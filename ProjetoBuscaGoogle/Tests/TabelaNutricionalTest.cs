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
        public void ChocolateCarboidratos()
        {
            driver.FindElement(By.Name("q")).SendKeys("chocolate carboidratos");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("61 g"));
        }

        [Test]
        public void ChocolateGordura()
        {
            driver.FindElement(By.Name("q")).SendKeys("chocolate gordura em 100g");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("31 g"));
        }

        [Test]
        public void ChocolateProteina()
        {
            driver.FindElement(By.Name("q")).SendKeys("chocolate proteina em 100g");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("4,9 g"));
        }

        [Test]
        public void ChocolateCafeina()
        {
            driver.FindElement(By.Name("q")).SendKeys("chocolate cafeína em 100g");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("43 mg"));
        }

        [Test]
        public void ChocolateCalorias()
        {
            driver.FindElement(By.Name("q")).SendKeys("chocolate calorias em 100g");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("546 calorias"));
        }
    }
