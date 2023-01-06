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
public class PerguntasTest {
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
  public void PerguntaBeatles() {

        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Ano do fim dos Beatles");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("1970"));
   }

   [Test]
   public void PerguntaCocaCola()
   {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Ano e local que a Coca Cola foi fundada");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("1892, Atlanta, Geórgia, EUA"));
   }

    [Test]
    public void PerguntaClubedaLuta()
    {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Ano de lançamento do filme Clube da Luta");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("29 de outubro de 1999"));
    }

    [Test]
    public void PerguntaAstronautaLua()
    {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Qual é o nome do primeiro astronauta que pisou na lua?");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("Neil Armstrong"));
    }

    [Test]
    public void PerguntaCorinthians()
    {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Data em que o Corinthians foi fundado");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("1 de setembro de 1910"));
    }

    [Test]
    public void PerguntaYujiItadori()
    {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Nome do protagonista de Jujutsu Kaisen");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("Yuji Itadori"));
    }

    [Test]
    public void PerguntaGrecia()
    {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Qual continente fica a Grecia");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("Europa"));
    }


    [Test]
    public void PerguntaRussia()
    {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Qual maior país do mundo em km");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("Rússia"));
    }

    [Test]
    public void PerguntaMarvel()
    {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Fundador da Marvel");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("Martin Goodman"));
    }

    [Test]
    public void PerguntaJapão()
    {
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("Qual é a capital do Japão?");
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        Assert.That(driver.FindElement(By.CssSelector(".Z0LcW")).Text, Is.EqualTo("Tóquio"));
    }


}
