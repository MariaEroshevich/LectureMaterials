using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Advanced
{
    [TestFixture]
    public class SeleniumAdvancedTests
    {
        private IWebDriver Driver { get; set; }

        private WebDriverWait Waiter { get; set; }

        private TimeSpan _timeout = TimeSpan.FromSeconds(5);

        private const string epamUrl = "https://www.epam.com/";

        [SetUp]
        public void SetupDriver()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(epamUrl);
        }

        [SetUp]
        public void SetupWaiter()
        {
            Waiter = new WebDriverWait(Driver, _timeout);
            Waiter.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
        }

        [Test]
        public void CheckSearchButtonOpensSearchPanel()
        {
            var searchButton = Driver.FindElement(By.XPath("//*[@class='header-search__button header__icon']"));
            searchButton.Click();

            // simple explicit wait
            //var searchPanel = Waiter.Until(driver => driver.FindElement(By.XPath("//*[contains(@class, 'header-search__panel opened')]")));
            //Assert.That(searchPanel.Displayed, Is.True, "Search Panel should be present!");

            var searchPanelDisplayedState = Waiter.Until(function =>
            {
                try
                {
                    var searchPanel =
                        Driver.FindElement(By.XPath("//*[contains(@class, 'header-search__panel opened')]"));
                    return searchPanel.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            Assert.That(searchPanelDisplayedState, Is.True, "Search Panel is not present!");
        }

        [Test]
        public void CheckEpamMenuCareersLink()
        {
            var action = new Actions(Driver);

            var careersMenuElement = Driver.FindElement(By.XPath("//*[@href='/careers']"));
            action.MoveToElement(careersMenuElement).Build().Perform();

            var hiringLink = Driver.FindElement(By.XPath("//*[@href='/careers/locations']"));
            hiringLink.Click();

            Assert.That(Driver.Url, Is.EqualTo("https://www.epam.com/careers/locations"), "Locations Page should be opened!");
        }

        [TestCase("https://www.epam.com/cis", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[3]/a")]
        //[TestCase("https://careers.epam-czech.cz/", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[4]/a")]
        //[TestCase("https://www.epam.de/", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[10]/a")]
        //[TestCase("https://www.epam.com/careers/epam-japan", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[8]/a")]
        //[TestCase("https://careers.epam.ua/", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[6]/a")]
        //[TestCase("https://careers.epam.cn/", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li/div/nav/ul/li[9]/a")]
        public void LanguageSwitchCheck(string urlLang, string xPath)
        {
            Driver.Navigate().GoToUrl(epamUrl);
            Driver.FindElement(By.ClassName("location-selector__button")).Click();
            Driver.FindElement(By.XPath(xPath)).Click();
            Assert.That(Driver.Url, Is.EqualTo(urlLang), "Language has not changed!");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}