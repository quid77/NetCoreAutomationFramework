using NUnitTestProject.Application.Helpers;
using OpenQA.Selenium;

namespace NUnitTestProject.Application.Pages.PageBase
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        protected By pageCheckerLocator;
        protected Assertions assertions = new Assertions();

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void VerifyPageLoaded()
        {
            assertions.VerifyPageElementDisplayed(pageCheckerLocator, true);
        }
    }
}
