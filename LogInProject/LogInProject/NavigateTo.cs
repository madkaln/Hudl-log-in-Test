using LogInProject.UI_Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInProject
{
    class NavigateTo
    {
        public static void NavigateToLogInPage(IWebDriver driver)
        {
            //using method that is in the Home page and navigates to LogIn page
            HomePage menu = new HomePage(driver);
            //initialise and click the log in elements that I have defined in te UI Element - LogIn page get;set;
            menu.LogInButton.Click();         

        }

    }
}
