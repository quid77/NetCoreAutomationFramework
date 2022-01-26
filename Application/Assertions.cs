using NUnit.Framework;
using NUnitTestProject.Application.Helpers;
using OpenQA.Selenium;

namespace NUnitTestProject.Application
{
    public class Assertions
    {
        private IWebDriver driver = DriverProvider.GetDriver();

        //verifies if partcicular element is displayed on page
        public void VerifyPageElementDisplayed(By locator, bool isChecker)
        {
            bool isDisplayed = driver.FindElements(locator).Count > 0;

            if (isChecker)
            {
                Assert.IsTrue(isDisplayed);
            }
            else
            {
                Assert.IsFalse(isDisplayed);
            }
        }
    }
}
