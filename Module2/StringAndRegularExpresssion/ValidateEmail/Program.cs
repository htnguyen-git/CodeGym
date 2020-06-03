using System;
using System.Text.RegularExpressions;
namespace ValidateEmail
{
    public class Program
    {
        static EmailExample emailExample;
        static string[] validEmail = new string[] { "a@gmail.com", "ab@yahoo.com", "abc@hotmail.com" };
        static string[] invalidEmail = new string[] { "@gmail.com", "ab@gmail.", "@#abc@gmail.com" };
        static void Main(string[] args)
        {
            emailExample = new EmailExample();
            foreach (var email in validEmail)
            {
                bool isValid = emailExample.Validate(email);
                Console.WriteLine($"Email {email} is valid : {isValid}");
            }
            foreach (var email in invalidEmail)
            {
                bool isValid = emailExample.Validate(email);
                Console.WriteLine($"Email {email} is valid : {isValid}");
            }
        }
    }
}
