using System;
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

        private const string _videoLocator = "video";

        [SetUp]
        public void InitializePage()
        {
            Driver = new ChromeDriver();
            //Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(epamUrl);
        }

        [Test]
        public void CheckNavigationToEpamSite()
        {
            // Api().GetUser()
            // LoginPage().Login(user);
            //Driver.Navigate().GoToUrl(epamUrl);

            //By Tag <> </>
            var elementByTagName = Driver.FindElement(By.TagName(_videoLocator));

            // By attribute "class" name
            var elementByClassName = Driver.FindElement(By.ClassName("header__logo-container"));

            var elementById = Driver.FindElement(By.Id("vq_tracking"));
            // if test fails due to inability to wait for page - add this wait
            //Thread.Sleep(3000);

            //Assert.That(element.Displayed, Is.True, "Element is not present!");
        }

        [Test]
        public void CheckEpamLogoDisplayed()
        {
            //var logoElement = Driver.FindElement(By.ClassName("header__logo"));
            //Assert.That(logoElement.Displayed, Is.True, "Incorrect presence state for EPAM logo!");

            //var menuElements = Driver.FindElements(By.XPath("//*[@class = 'header-search__button header__icon'] | //*[@aria-expanded = 'false']')]"));
            var menuElement = Driver.FindElement(By.XPath("//li[contains(@class, 'top-navigation__item')]"))
                .FindElement(By.XPath(".//a"));
            menuElement.Click();
            Assert.That(Driver.Url, Is.EqualTo("https://www.epam.com/services"));
            //Assert.That(menuElements, Has.Count.EqualTo(6), "Incorrect number of menu items");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}