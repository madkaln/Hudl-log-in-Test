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

    public class LoginWithInvalidUsername
    {

     public LoginWithInvalidUsername()
        {

        }
        public IWebDriver Driver { get; set; }

        /*This is where you have to provide username, password and repeat password
        *usng config file to supply the login details e.g valid credentials
        *set up everything before the test starts!
        */

        [OneTimeSetUp]
        public void Initlize()
        {
            Driver = Actions.InitlizeDriver();
            NavigateTo.NavigateToLogInPage(Driver);
        }
        //between SetUp and TearDown creat tests.
        //first test method

        /* Equal to see what we expect vs actual
        */
        [Test]

        //Test where I have a valid Password but invalid Email Address.
        public void InvalidUserName()
        {
            Actions.FillLoginForm(TestBase.Credentials.Invalid.Username.IncorrectEmail,
                                TestBase.Credentials.Valid.Password,
                                Driver);

            Thread.Sleep(5000);

            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);

        }
        [Test]

        //Test where I have a valid Password but invalid Email Address.
        public void InvalidUserName2()
        {
            Actions.FillLoginForm(TestBase.Credentials.Invalid.Username.IncorrectSecondEmail,
                                TestBase.Credentials.Valid.Password,
                                Driver);

            Thread.Sleep(5000);

            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);

        }
        [Test]

        //Test where I have a valid Password but invalid Email Address.
        public void InvalidUserName3()
        {
            Actions.FillLoginForm(TestBase.Credentials.Invalid.Username.IncorrectThirdEmail,
                                TestBase.Credentials.Valid.Password,
                                Driver);

            Thread.Sleep(5000);

            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);

        }
        public void InvalidUserName4()
        {
            Actions.FillLoginForm(TestBase.Credentials.Invalid.Username.IncorrectFourthEmail,
                                TestBase.Credentials.Valid.Password,
                                Driver);

            Thread.Sleep(5000);
            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);

        }
        //user assertions to confirm if test is succesfull


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}
  
