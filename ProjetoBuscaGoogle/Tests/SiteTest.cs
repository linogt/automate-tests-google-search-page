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
    public class SiteTest
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
            driver.FindElement(By.Name("q")).SendKeys("\"site:concert.com.br\"");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            {
                var element = driver.FindElement(By.CssSelector(".kvH3mc:nth-child(2) .LC20lb"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }


    [Test]
    public void site1()
    {
        Assert.That(driver.FindElement(By.CssSelector(".kvH3mc:nth-child(2) a > .TbwUpd")).Text, Is.EqualTo("https://www.concert.com.br"));
    }

}
