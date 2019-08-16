using AutomationPractice.MainClasses;
using OpenQA.Selenium;

namespace AutomationPractice.HelpClasses
{
    public class DriverClass
    {
        protected IWebDriver _driver;
        protected IWebElement _element;

        public DriverClass()
        {
            _driver = DriverSingleton.Driver;
        }

        public void End()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
