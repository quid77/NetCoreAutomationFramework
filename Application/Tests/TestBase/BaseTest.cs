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

        //set up config file to be readable while using .NET Core Framework 
        [OneTimeSetUp]
        public void SetUpConfigFile()
        {
            //var asd = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //var testDllName = Assembly.GetAssembly(GetType()).GetName().Name;
            //var configName = testDllName + ".dll.config";
            //AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", configName);
        }

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
