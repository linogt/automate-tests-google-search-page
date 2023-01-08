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
using OpenQA.Selenium.Edge;

namespace MainTest
{


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
    Thread.Sleep(3000);
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
    
    [Test]
    public void Contas()
    {       //Soma
            PesquisarPergunta("0+0");
            CompararResposta("0");
            //Soma
            PesquisarPergunta("2+2");
            CompararResposta("4");
            //Subtração
            PesquisarPergunta("2-2");
            CompararResposta("0");
            //Multiplicação
            PesquisarPergunta("2*2");
            CompararResposta("4");
            //Divisão
            PesquisarPergunta("2/2");
            CompararResposta("1");
            //Potenciação
            PesquisarPergunta("2^2");
            CompararResposta("4");
            //Multiplicação
            PesquisarPergunta("2*10");
            CompararResposta("20");
            //Subtração
            PesquisarPergunta("20-50");
            CompararResposta("-30");
            //Subtração
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