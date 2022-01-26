using OpenQA.Selenium;

namespace NUnitTestProject.Application.Helpers
{
    public class ElementHelper
    {
        private WaitHelper waitHelper = new WaitHelper();

        public void Type(IWebElement element, string text)
        {
            waitHelper.WaitForElementToBeClickable(element);
            element.Clear();
            element.SendKeys(text);
        }

        public void Click(IWebElement element)
        {
            waitHelper.WaitForElementToBeClickable(element);
            element.Click();
        }
    }
}
