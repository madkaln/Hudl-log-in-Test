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

    public class LogInWithInvalidPassword
        {

            public LogInWithInvalidPassword()
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

            [Test]

            //Test where I have a valid Password but invalid Email Address.
            public void InvalidPassword()
            {
                Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                                    TestBase.Credentials.Invalid.Password.IncorrectPassword,
                                    Driver);

            Thread.Sleep(5000);


            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);

        }
            [Test]

            //Test where I have a valid Password but invalid Email Address.
            public void InvalidPasswordWithFiveLetters()
            {
            Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                                 TestBase.Credentials.Invalid.Password.Passwordwithfiveletters,
                                 Driver);

            Thread.Sleep(5000);

            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);

        }
            [Test]

            //Test where I have a valid Password but invalid Email Address.
            public void InvalidPasswordWithJustNumbers()
            {
            Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                              TestBase.Credentials.Invalid.Password.PasswordwithJustNumbers,
                              Driver);

            Thread.Sleep(5000);

            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);


        }
            public void InvalidPasswordwithSpecialCharacters()
            {
            Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                           TestBase.Credentials.Invalid.Password.PasswordWithSpecialCharacters,
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
