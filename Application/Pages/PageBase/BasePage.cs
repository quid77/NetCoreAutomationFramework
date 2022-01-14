using OpenQA.Selenium;

namespace NUnitTestProject.Application.Pages.PageBase
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected By pageCheckerLocator;
        protected Assertions assertions = new Assertions();

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void VerifyPageLoaded()
        {
            assertions.VerifyPageElementDisplayed(pageCheckerLocator, true);
        }
    }
}
