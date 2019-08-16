using AutomationPractice.HelpClasses;
using AutomationPractice.HelpClasses.Waits;
using OpenQA.Selenium;
using System;

namespace AutomationPractice.SeleniumClasses
{
    public class SeleniumSetClasses: DriverClass
    {
        WaitClass _wait;
        Find _find;

        public SeleniumSetClasses()
        {
            _find = new Find();
            _wait = new WaitClass();
        }

        public void ClickElement(By selector, int maxWaitTime = WaitSettings.WaitStandard)
        {
            _wait.WaitForElement(selector, maxWaitTime);
            _element = _find.FindElement(selector);
            _element.Click();
        }

        public void EnterText(By selector, string value, int maxWaitTime = WaitSettings.WaitStandard)
        {
            _wait.WaitForElement(selector, maxWaitTime);
            _element = _find.FindElement(selector);
            _element.SendKeys(value);
        }
    }
}
