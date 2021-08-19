using System;

namespace Email_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email Regex Demo!");
            EmailCheck emailCheck = new EmailCheck();
            bool result2 = emailCheck.validateEmail("sandeepshinde630@gmail.com");
            Console.WriteLine(result2);
        }
    }
}
