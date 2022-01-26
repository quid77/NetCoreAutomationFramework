using NUnitTestProject.Application.Pages.PageBase;
using OpenQA.Selenium;

namespace NUnitTestProject.Application.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
            pageCheckerLocator = By.CssSelector("div.srch");
        }

        //PAGE ELEMENTS
        private IWebElement SeleniumTutorialsButton => driver.FindElement(By.CssSelector("img[src*='selenium-logo']"));

        //PAGE METHODS
        public SeleniumTutorialsPage GoToSeleniumTutorialsPage()
        {
            elementHelper.Click(SeleniumTutorialsButton);
            SeleniumTutorialsPage seleniumTutorialsPage = new SeleniumTutorialsPage(driver);
            seleniumTutorialsPage.VerifyPageLoaded();

            return seleniumTutorialsPage;
        }
    }
}
