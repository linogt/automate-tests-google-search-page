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
public class AritmeticaTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    driver.Navigate().GoToUrl("https://www.google.com.br/");
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
    [Test]
    public void Mat1() {
        driver.FindElement(By.Name("q")).SendKeys("2+2");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("4"));
    }

    [Test]
    public void Mat2()
    {
        driver.FindElement(By.Name("q")).SendKeys("2-2");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("0"));
    }

    [Test]
    public void Mat3()
    {
        driver.FindElement(By.Name("q")).SendKeys("2/2");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("1"));
    }

    [Test]
    public void Mat4()
    {
        driver.FindElement(By.Name("q")).SendKeys("2*2");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("4"));
    }

    [Test]
    public void Mat5()
    {
        driver.FindElement(By.Name("q")).SendKeys("2^2");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("4"));
    }

    [Test]
    public void Mat6()
    {
        driver.FindElement(By.Name("q")).SendKeys("-2-2");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("-4"));
    }

    [Test]
    public void Mat7()
    {
        driver.FindElement(By.Name("q")).SendKeys("2*10");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("20"));
    }

    [Test]
    public void Mat8()
    {
        driver.FindElement(By.Name("q")).SendKeys("20-50");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("-30"));
    }

    [Test]
    public void Mat9()
    {
        driver.FindElement(By.Name("q")).SendKeys("10+10");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("20"));
    }

    [Test]
    public void Mat10()
    {
        driver.FindElement(By.Name("q")).SendKeys("0+0");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.Id("cwos")).Text, Is.EqualTo("0"));
    }

}
