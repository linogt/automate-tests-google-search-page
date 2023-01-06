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
public class LayoutRodapeTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    driver.Navigate().GoToUrl("https://www.google.com/");
  }
  [TearDown]
  protected void TearDown() {
        driver.Close();
        driver.Quit();
  }

 
  
  [Test]
  public void Sobre() {
    Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[1]")).Text, Is.EqualTo("Sobre"));
  }

  [Test]
  public void Publicidade() {
    Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[2]")).Text, Is.EqualTo("Publicidade")); 
  }
    
  [Test]
  public void Negocios() {
    Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[3]")).Text, Is.EqualTo("Negócios"));
  }
    
  [Test]
  public void ComoFuncionaAPesquisa() {
    Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[4]")).Text, Is.EqualTo("Como funciona a Pesquisa"));
  }
    
  [Test]
  public void Privacidade() {
    Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[2]/a[1]")).Text, Is.EqualTo("Privacidade"));
  }

    [Test]
    public void Termos()
    {
        Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[2]/a[2]")).Text, Is.EqualTo("Termos"));
    }

    [Test]
    public void Configuracoes()
    {
        Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[2]/span/span/g-popup/div[1]/div")).Text, Is.EqualTo("Configurações"));
    }


}
