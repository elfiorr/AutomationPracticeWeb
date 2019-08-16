using AutomationPractice.HelpClasses;
using AutomationPractice.SeleniumClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.NewParadigmat
{
    class BasicClass
    {
        private protected readonly SeleniumSetClasses SetClasses;
        private protected readonly WaitClass WaitClass;
        private protected readonly Find Find;
        private protected readonly By MainLocator;

        protected BasicClass(By locator)
        {
            SetClasses = new SeleniumSetClasses();
            Find = new Find();
            MainLocator = locator;
        }

        public bool IsVisible()
        {
            return Find.FindElement(MainLocator).Enabled;
        }

        public bool IsActive()
        {
            return Find.FindElement(MainLocator).Displayed;
        }

        public bool IsReadOnly()
        {
            return IsVisible() && !IsActive();
        }
    }
}
