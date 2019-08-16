using AutomationPractice.HelpClasses.Waits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPractice.HelpClasses
{
    public class WaitClass: DriverClass
    {
        public WaitClass()
        {
        }

        public void WaitForElement(By selector, int maxWaitTime = WaitSettings.WaitStandard)
        {
            ExplicityWait(selector, TimeSpan.FromMilliseconds(maxWaitTime));
        }

        public void ExplicityWait(By selector, TimeSpan time)
        {
            WebDriverWait _wait = new WebDriverWait(_driver, time);
            _wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            _element = _wait.Until<IWebElement>(d => d.FindElement(selector));
        }
    }
}
