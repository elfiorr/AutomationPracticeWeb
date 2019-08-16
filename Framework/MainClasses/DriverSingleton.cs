using OpenQA.Selenium;
using System;

namespace AutomationPractice.MainClasses
{
    public static class DriverSingleton
    {
        public static void InitializeDriver()
        {
            try
            {
                Console.WriteLine("Initializing chromedriver first try");
                _driver = DriverFactory.Get();
            }

            catch
            {
                Console.WriteLine("Initializing chromedriver second try");
                _driver = DriverFactory.Get();
            }
        }

        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)

                    InitializeDriver();
                return _driver;
            }
            private set => _driver = value;
        }
    }

}

