using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System;
using LogInProject.UI_Elements;

/*Action class performs all the actions
 * Fill in the log in form and initialises drivers
 */

namespace LogInProject
{
          public static class Actions
        {
            public static IWebDriver InitlizeDriver()
            {

                // new test intialise in its own driver and then quick the driver
                //when it goes to the second driver it will initalise it in its class then close it at the end

                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(TestBase.BaseURL);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                return driver;
            }

            /* This method is sending a simple text to the log in form
            *Fill in the arguments for each of the fields
            */

            public static void FillLoginForm(string email,
                                            string password,
                                            IWebDriver driver)

            {
            LogInPage logIn = new LogInPage(driver);


            //using clear to clear any content before its run. e.g. all the inputs in the text field.

            logIn.UserNameField.Clear();
            logIn.UserNameField.SendKeys(email);

            logIn.PasswordField.Clear();
            logIn.PasswordField.SendKeys(password);

            logIn.LogInButton.Click();

         }
         

        }

 }
