using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using System.Drawing;

namespace AutomationPractice.MainClasses
{
    public class DriverFactory
    {
        const int _browserWidth = 1050;
        const int _browserHeight = 768;

        public static IWebDriver Get()
        {
            IWebDriver driver;

            switch (ConfigurationManager.AppSettings["Browser"])
            {
                case "firefox":

                    FirefoxOptions profile = new FirefoxOptions();
                    profile.AcceptInsecureCertificates = true;
                    if (ConfigurationManager.AppSettings["HeadlessBrowser"] == "true")
                        profile.AddArgument("--headless");
                    var firefoxservice = FirefoxDriverService.CreateDefaultService();
                    firefoxservice.HideCommandPromptWindow = true;
                    driver = new FirefoxDriver(firefoxservice, profile);

                    break;

                default:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    if (ConfigurationManager.AppSettings["HeadlessBrowser"] == "true")
                        chromeOptions.AddArgument("--headless");
                    chromeOptions.AddArgument("--disable-infobars");
                    chromeOptions.AddArgument("--no-sandbox");
                    chromeOptions.AddArgument("--disable-extensions");
                    chromeOptions.AddArgument("--dns-prefetch-disable");
                    chromeOptions.AddArgument("--disable-browser-side-navigation");
                    chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
                    chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
                    //chromeOptions.AddUserProfilePreference("download.default_directory", TestContexts.GetDownloadDirectory());
                    chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
                    chromeOptions.AddUserProfilePreference("download.directory_upgrade", false);
                    chromeOptions.AddUserProfilePreference("safebrowsing.enabled", false);
                    chromeOptions.AddArgument("--enable-automation");
                    var chromeDriverService = ChromeDriverService.CreateDefaultService();
                    chromeDriverService.HideCommandPromptWindow = true;

                    driver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromSeconds(600));

                    break;
            }

            driver.Manage().Window.Size = new Size(_browserWidth, _browserHeight);

            return driver;
        }
    }
}
