using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Basic
{
    public class EpamSiteNavigationTests
    {
        private IWebDriver Driver { get; set; }
        private const string epamUrl = "https://www.epam.com/";

        [SetUp]
        public void InitializePage()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();

            Driver.Navigate().GoToUrl(epamUrl);
        }

        [Test]
        public void CheckNavigationToEpamSite()
        {
            // Api().GetUser()
            // LoginPage().Login(user);
            Driver.Navigate().GoToUrl(epamUrl);

            // if test fails due to inability to wait for page - add this wait
            //Thread.Sleep(3000);

            Assert.That(Driver.Url, Is.EqualTo(epamUrl), "Incorrect Url is present!");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}