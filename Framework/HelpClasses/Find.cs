using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.HelpClasses
{
    public class Find: DriverClass
    {
        public IWebElement FindElement(By selector)
        {
            _element = _driver.FindElement(selector);

            return _element;
        }
    }
}
