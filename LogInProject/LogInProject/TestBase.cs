﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Test Base file is used for vairables that are used in multiple places and
 * through out the framework. E.g username, password I can call all anywhere in classess as they are public static
 */

namespace LogInProject
{
    class TestBase
    {
        //base url
        public static string BaseURL = "https://www.hudl.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "madara.k@hotmail.co.uk";
                public static string Password = "14thOct!";             
            }

            public static class Invalid
            {
                public static class Email
                {
                    public static string IncorrectEmail = "madara@hotmail.co.uk";
                    public static string IncorrectSecondEmail = "madara.kalnavarna@hotmail.co.uk";
                    public static string IncorrectThirdEmaiil = "madara.k@otmail.co.uk";
                    public static string IncorrectFourthEmaiil = "madarak@otmail.co.uk";

                }
                public static class Password
                {
                    public static string IncorrectPassword = "testing123";
                    public static string PasswordwithJustNumbers = "1234";
                    public static string Passwordwithfiveletters = "1234";
                    public static string PasswordWithSpecialCharacters = "£!()";

                }
            }

        }
    }
}