using AutomationPractice.SeleniumClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsForTests.MainPageOfWeb
{
    internal class MainActions
    {
        private readonly SeleniumSetClasses _setMethods = new SeleniumSetClasses();
        private readonly By _signIn = By.CssSelector(".login");

        internal void ClickSignIn()
        {
            _setMethods.ClickElement(_signIn);
        }
    }
}
