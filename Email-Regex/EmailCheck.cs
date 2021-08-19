using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Email_Regex
{
    public class EmailCheck
    {
        public static string Email = "^[a-z]+([._+-]*[a-z0-9]+)*[@][a-z0-9]+[.][a-z]{2,3}(.[a-z]{2})?$";
        public bool validateEmail(string input)
        {
            return Regex.IsMatch(input, Email);
        }
    }
}
