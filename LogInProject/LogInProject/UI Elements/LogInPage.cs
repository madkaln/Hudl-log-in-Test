using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInProject.UI_Elements
{

    //Log in page driver with all the IWeb Elements are stored here.
    class LogInPage
    {
        public LogInPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
       [FindsBy(How = How.Id, Using = "email")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordField { get; set; }


        //This particular element is used to find the login button
        [FindsBy(How = How.Id, Using = "logIn")]
        public IWebElement LogInButton { get; set; }

    }
}
