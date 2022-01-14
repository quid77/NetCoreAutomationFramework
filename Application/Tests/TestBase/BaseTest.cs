using NUnit.Framework;
using NUnitTestProject.Application.Helpers;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Reflection;

namespace NUnitTestProject.Application.Tests.TestBase
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUpBeforeTest()
        {
            string basePageUrl = ConfigurationManager.AppSettings["AppBaseUrl"];
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
