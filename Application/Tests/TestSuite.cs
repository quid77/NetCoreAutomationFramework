using NUnit.Framework;
using NUnitTestProject.Application.Pages;
using NUnitTestProject.Application.Tests.TestBase;

namespace NUnitTestProject.Application.Tests
{
    public class TestSuite : BaseTest
    {
        private MainPage mainPage;
        private SeleniumTutorialsPage seleniumTutorialsPage;

        [SetUp]
        public void SetUp()
        {
            mainPage = new MainPage(driver);
            seleniumTutorialsPage = new SeleniumTutorialsPage(driver);
        }

        [Test]
        public void Test()
        {
            mainPage.GoToSeleniumTutorialsPage();
            seleniumTutorialsPage.VerifySoftwareTestingLinkIsVisible();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
