using NUnit.Framework;
using NUnitTestProject.Application.Helpers;
using OpenQA.Selenium;
using System;

namespace NUnitTestProject.Application.Tests.TestBase
{
    public abstract class BaseTest
    {
        protected IWebDriver driver;
        protected ConfigReader config = new ConfigReader();

        [SetUp]
        public void SetUpBeforeTest()
        {
            string basePageUrl = config.GetProperty("AppBaseUrl");
            DriverProvider.CreateDriver();
            driver = DriverProvider.GetDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl(basePageUrl);
        }

        [TearDown]
        public void TearDownAfterTest()
        {
            driver.Quit();
        }
    }
}
