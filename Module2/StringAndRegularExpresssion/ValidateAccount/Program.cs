using System;

namespace ValidateAccount
{
    class Program
    {
        private static AccountRegex accountExample;
        static string[] validAccount = new String[] { "123abc_", "_abc123", "______", "123456", "abcdefgh" };
        static string[] invalidAccount = new String[] { ".@", "12345", "1234_", "abcde" };
        static void Main(string[] args)
        {
            accountExample = new AccountRegex();
            foreach (string account in validAccount)
            {
                bool isvalid = accountExample.Validate(account);
                Console.WriteLine("Account is " + account + " is valid: " + isvalid);
            }
            foreach (string account in invalidAccount)
            {
                bool isvalid = accountExample.Validate(account);
                Console.WriteLine("Account is " + account + " is valid: " + isvalid);
            }
        }
    }
}
