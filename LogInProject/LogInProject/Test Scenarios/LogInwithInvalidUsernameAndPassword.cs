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

        public class LogInwithInvalidUsernameAndPassword

    {
            public LogInwithInvalidUsernameAndPassword()
            {

            }
            public IWebDriver Driver { get; set; }

            /*This is where you have to provide username, password
            //set up everything before the test starts!*/

            [OneTimeSetUp]
            public void Initlize()
            {
                Driver = Actions.InitlizeDriver();
                NavigateTo.NavigateToLogInPage(Driver);
            }
        //between SetUp and TearDown creat tests.
        //first test method
        [Test]

        public void InvalidLoginAndPassword()
        {
            Actions.FillLoginForm(TestBase.Credentials.Invalid.Username.IncorrectEmail,
                                TestBase.Credentials.Invalid.Password.IncorrectPassword,
                                Driver);

            Thread.Sleep(5000);
            //user assertions to confirm if test is succesfull
            //Finds element on the log-in page and then asserts if its equal to incorrect details.

            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);

          }
        

        [OneTimeTearDown]
            public void CleanUp()
            {
                Driver.Quit();
            }

        }
}



