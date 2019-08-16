using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.NewParadigmat
{
    class InputClass: BasicClass
    {
        public InputClass(By locator) : base(locator)
        {
        }

        public InputClass(string onkeyup, bool onDialog = false) : base(
            By.CssSelector(onDialog ? $".ui-dialog [data-binding='{onkeyup}']" : $"[data-binding='{onkeyup}']"))
        {
        }

        public void EnterValue(string value)
        {
            if (value != null)
            {
              //  SetClasses.SendKeysToElement(MainLocator, value);
            }
        }

        public string GetValue()
        {
            return Find.FindElement(MainLocator).GetAttribute("value");
        }

        public void Clear()
        {
            Find.FindElement(MainLocator).Clear();
        }
    }
}
