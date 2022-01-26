using NUnitTestProject.Application.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject.Application.Pages.PageBase
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        protected By pageCheckerLocator;

        protected Assertions assertions = new Assertions();
        protected ConfigReader config = new ConfigReader();
        protected ElementHelper elementHelper = new ElementHelper();

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForPageToLoad()
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(double.Parse(config.GetProperty("AppDefaultWaiTimeout"))));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return typeof(jQuery) == 'function' ? (jQuery.active == 0) : true").Equals(true));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void VerifyPageLoaded()
        {
            assertions.VerifyPageElementDisplayed(pageCheckerLocator, true);
        }
    }
}
