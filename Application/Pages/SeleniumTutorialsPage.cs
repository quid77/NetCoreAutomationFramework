using NUnitTestProject.Application.Pages.PageBase;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject.Application.Pages
{
    public class SeleniumTutorialsPage : BasePage
    {
        public SeleniumTutorialsPage(IWebDriver driver) : base(driver)
        {
            pageCheckerLocator = By.CssSelector("a[href='software-testing.html']");
        }

        //PAGE ELEMENTS
        private IWebElement BasicSoftwareTestingLink => driver.FindElement(By.CssSelector("a[href='software-testing.html']"));

        //PAGE LOCATORS
        private By BasicSoftwareTestingLinkLocator => By.CssSelector("a[href='software-testing.html']");


        //PAGE METHODS
        public void VerifySoftwareTestingLinkIsVisible()
        {
            assertions.VerifyPageElementDisplayed(BasicSoftwareTestingLinkLocator, true);
        }
    }
}
