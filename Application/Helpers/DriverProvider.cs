using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace NUnitTestProject.Application.Helpers
{
    public class DriverProvider
    {
        public static IWebDriver driver;

        public static void CreateDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);

            ChromeOptions options = new ChromeOptions();
            options.PageLoadStrategy = PageLoadStrategy.Normal;
            options.AddArgument("enable-automation");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--disable-browser-side-navigation");
            options.AddArgument("--disable-gpu");

            driver = new ChromeDriver(options);

            //if (headless)
            //{
            //    options.AddArgument("--headless");
            //    options.AddArgument("window-size=1920,1080");
            //}
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
