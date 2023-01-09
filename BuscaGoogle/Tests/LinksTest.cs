using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace MainTest
{
    [TestFixture]
    public class LinksTest
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
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Close();
            driver.Quit();
        }



        [Test]
        public void LinksPag()
        {
            //Pesquisa Google (Teste Caixa Vazia)
            ClicarLink("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]");
            CompararLink("https://www.google.com/");

            //Estou com Sorte
            ClicarLink("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[2]");
            CompararLink("https://www.google.com/doodles");

            //Imagem
            ClicarLink("/html/body/div[1]/div[1]/div/div/div/div[1]/div/div[2]/a");
            CompararLink("https://www.google.com.br/imghp?hl=pt-BR&ogbl");

            //Sobre
            ClicarLink("/html/body/div[1]/div[5]/div[2]/div[1]/a[1]");
            CompararLink("https://about.google/?utm_source=google-BR&utm_medium=referral&utm_campaign=hp-footer&fg=1");

            //Publicidade
            ClicarLink("/html/body/div[1]/div[5]/div[2]/div[1]/a[2]");
            CompararLink("https://ads.google.com/intl/pt-BR_br/home/?subid=ww-ww-et-g-awa-a-g_hpafoot1_1!o2&utm_source=google.com&utm_medium=referral&utm_campaign=google_hpafooter&fg=1");

            //Negócios
            ClicarLink("/html/body/div[1]/div[5]/div[2]/div[1]/a[3]");
            CompararLink("https://smallbusiness.withgoogle.com/intl/pt-BR_br/?subid=ww-ww-et-g-awa-a-g_hpbfoot1_1!o2&utm_source=google&utm_medium=ep&utm_campaign=google_hpbfooter&utm_content=google_hpbfooter&gmbsrc=ww-ww-et-gs-z-gmb-s-z-u~sb-g4sb_srvcs-u&c=BR#!/");

            //Como funciona a Pesquisa
            ClicarLink("/html/body/div[1]/div[5]/div[2]/div[1]/a[4]");
            CompararLink("https://www.google.com/search/howsearchworks/?fg=1");

            //Privacidade
            ClicarLink("/html/body/div[1]/div[5]/div[2]/div[2]/a[1]");
            CompararLink("https://policies.google.com/privacy?hl=pt-BR&fg=1");

            //Termos
            ClicarLink("/html/body/div[1]/div[5]/div[2]/div[2]/a[2]");
            CompararLink("https://policies.google.com/terms?hl=pt-BR&fg=1");

        }

        public void ClicarLink(String link)
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.XPath(link)).Click();
        }

        public void CompararLink(string link)
        {
            Assert.That(driver.Url, Is.EqualTo(link));
        }
    }
}