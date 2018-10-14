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

            /*This is where you have to provide username, password
            //set up everything before the test starts!*/

            [OneTimeSetUp]
            public void Initlize()
            {
                Driver = Actions.InitlizeDriver();
                NavigateTo.NavigateToLogInPage(Driver);
            }
        //between SetUp and TearDown create tests.
        [Test]


        // Valid Log in details
        public void ValidLogIn()
        {
            Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                                TestBase.Credentials.Valid.Password,
                                Driver);

            Thread.Sleep(5000);

         //comparing an element that is found after log in with the expected "AfterLogin"message   
         var LogInMessage = Driver.FindElement(By.CssSelector("#ssr-webnav > div > div.hui-webnav__grid.hui-navcontainer > nav.hui-webnav__grid-col--onewhole.hui-globalnav > div:nth-child(2) > a.hui-globalnav__item.hui-globalnav__explore")).Text;
         Assert.AreEqual(TestBase.AssertionMessages.AfterLogIn, LogInMessage);
        }

        [OneTimeTearDown]
            public void CleanUp()
            {
                Driver.Quit();
            }

        }
}



