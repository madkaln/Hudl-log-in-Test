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
            *usng TestBase file to supply the login details e.g valid credentials
            *set up everything before the test starts!
            */

            //Initialise the driver

            [OneTimeSetUp]
            public void Initlize()
            {
                Driver = Actions.InitlizeDriver();
                NavigateTo.NavigateToLogInPage(Driver);
            }
            //between SetUp and TearDown create tests.

            [Test]

            //Test where I have a valid Email but invalid password.
            public void InvalidPassword()
            {
                Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                                    TestBase.Credentials.Invalid.Password.IncorrectPassword,
                                    Driver);

            Thread.Sleep(5000);

            //Assertion to test that the log-in message matches the expected login error message
            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);

        }
            [Test]

            //Test where I have a valid email but invalid password with 5 letters
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

            //Test where I have a valid Email but password wiith just numbers.
            public void InvalidPasswordWithJustNumbers()
            {
            Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                              TestBase.Credentials.Invalid.Password.PasswordwithJustNumbers,
                              Driver);

            Thread.Sleep(5000);

            var LogInErrorMessage = Driver.FindElement(By.CssSelector("body > div.super-wrap > form.login-container > div.login-error.fade-in-expand > div > p")).Text;
            Assert.AreEqual(TestBase.AssertionMessages.IncorrectLogInDetails, LogInErrorMessage);


        }
            // Test password with special characters
             [Test]
            public void InvalidPasswordwithSpecialCharacters()
            {
            Actions.FillLoginForm(TestBase.Credentials.Valid.Email,
                           TestBase.Credentials.Invalid.Password.PasswordWithSpecialCharacters,
                           Driver);

            Thread.Sleep(5000);

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
