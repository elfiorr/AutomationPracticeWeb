using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsForTests.MainPageOfWeb
{
    public class MainPage
    {
        MainActions _actions = new MainActions();

        public void SignIn()
        {
            _actions.ClickSignIn();
        }
    }
}
