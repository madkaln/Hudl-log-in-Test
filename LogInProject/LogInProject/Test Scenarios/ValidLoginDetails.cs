using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogInProject
{
   
        [Parallelizable]

        public class ValidLoginDetails

        {
            public ValidLoginDetails()
            {

            }
            public IWebDriver Driver { get; set; }

            /*This is where you have to provide username, password and repeat password
                          /usng config file to supply the login details 
                          e.g valid credentials
            //Setting up Nunit.Framework 
            //set up everything before the test starts!*/

            [OneTimeSetUp]
            public void Initlize()
            {
                Driver = Actions.InitlizeDriver();
                NavigateTo.NavigateToLogInPage(Driver);
            }
            //between SetUp and TearDown creat tests.
            //first test method

            /* Equal to see what we expect vs actual
            *Using Config File to get the message.
            * Actual will be the alert box on what is appearing
            */
            [Test]

            public void ValidLogIn()
            {
                Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                                    TestBase.Credentials.Valid.Password,
                                    Driver);

                Thread.Sleep(5000);
           
            }
            //user assertions to confirm if test is succesfull
            //use IAlert to recognise that th test is validd

            /*in this particular case when logged
             * Alert box appears
             * For future reference, map out how to make assertions
             * ID? Need a bit of research on how to creat good assertions
            */

            [OneTimeTearDown]
            public void CleanUp()
            {
                Driver.Quit();
            }

        }
}



