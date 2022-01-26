using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace NUnitTestProject.Application.Helpers
{
    public class DriverProvider
    {
        private static IWebDriver driver;
        private static readonly ConfigReader config = new ConfigReader();

        private static readonly bool headless = bool.Parse(config.GetProperty("headless"));
        private static readonly string browser = config.GetProperty("browser");

        public static void CreateDriver()
        {
            if(browser.ToUpper().Equals("CHROME"))
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

                if (headless)
                {
                    options.AddArgument("--headless");
                    options.AddArgument("window-size=1920,1080");
                }

                driver = new ChromeDriver(options);
            }
            else if (browser.ToUpper().Equals("FIREFOX"))
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());

                FirefoxOptions options = new FirefoxOptions();
                options.AddArgument("--no-sandbox");
                options.AddArgument("--disable-infobars");
                options.AddArgument("--disable-dev-shm-usage");
                options.AddArgument("--disable-browser-side-navigation");
                options.AddArgument("--disable-gpu");

                if (headless)
                {
                    options.AddArgument("--headless");
                    options.AddArgument("window-size=1920,1080");
                }

                driver = new FirefoxDriver(options);
            }
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
