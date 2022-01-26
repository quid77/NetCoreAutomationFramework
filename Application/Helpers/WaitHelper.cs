using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace NUnitTestProject.Application.Helpers
{
    public class WaitHelper
    {
        private static ConfigReader config = new ConfigReader();
        private static IWait<IWebDriver> wait = new WebDriverWait(DriverProvider.GetDriver(), TimeSpan.Parse(config.GetProperty("WaitHelperTimeout")));

        //waits using expected conditions class

        public void WaitForElementToAppear(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void WaitForElementToDisappear(By locator)
        {
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public void WaitForElementToBeClickable(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void WaitForElementToBeClickable(IWebElement locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void WaitForElementTextToAppear(By locator, string text)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(locator, text));
        }

        //custom waits (without using lambda expressions)
        public void WaitUntilAttributeValueContains(By locator, string attributeName, string attributeValue)
        {
            IWebElement condition(IWebDriver driver)
            {
                IWebElement element = driver.FindElement(locator);
                if (element.GetAttribute(attributeName).Contains(attributeValue))
                {
                    return element;
                }
                return null;
            }

            wait.Until(condition);
        }

        public void WaitUntilNumberOfElementsIs(By locator, int number)
        {
            IList<IWebElement> condition(IWebDriver driver)
            {
                IList<IWebElement> listOfElements = driver.FindElements(locator);
                if (listOfElements.Count == number)
                {
                    return listOfElements;
                }
                return null;
            }

            wait.Until(condition);
        }
    }
}
