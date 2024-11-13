using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;

namespace TestProjectSelenium
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void mainTitle()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://kbkdist.ru";
            Assert.AreEqual("Образовательная платформа Калининградского бизнес-колледжа", webDriver.Title);
            webDriver.Close();
        }
        [TestCase]
        public void ya_request()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://ya.ru/";
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"text\"]"));
            search.SendKeys("функциональное тестирование");
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/main/div[3]/form/div[4]/button"));
            button.Click();
        }
        [TestCase]
        public void button_visible()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://ya.ru/";
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/main/div[3]/form/div[4]/button"));
            Assert.AreEqual(false,button.Displayed);
        }
    }
}