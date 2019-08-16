using System.Configuration;

namespace AutomationPractice.HelpClasses
{
    public class Navigate : DriverClass
    {
        private string _url = ConfigurationManager.AppSettings["URL"];

        public Navigate()
        {

        }

        public void NavigateToUrl()
        {
            GoToUrl();
        }

        public void GoToUrl() => _driver.Navigate().GoToUrl(_url);

        ///
        /// Ponizej jest to samo ale jako metoda
        ///

        //public void GoToUrl()
        //{
        //    _driver.Navigate().GoToUrl(_url);
        //}
    }
}
