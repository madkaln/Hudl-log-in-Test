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
        //between SetUp and TearDown creat tests.
        //first test method

        /* Equal to see what we expect vs actual
        *Using Config File to get the message.
        */
        [Test]

        public void ValidLogIn()
        {
            Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                                TestBase.Credentials.Valid.Password,
                                Driver);

            Thread.Sleep(5000);

           // Assert.IsTrue(Driver.FindElement(By.XPath(//*[@id="ssr-webnav"]/div/div[1]/nav[1]/div[4]/div[2]/div[1]/div[2]/descendant::span[text()='Jo Kalnavarna']")));
        }
        //user assertions to confirm if test is succesfull

        [OneTimeTearDown]
            public void CleanUp()
            {
                Driver.Quit();
            }

        }
}



