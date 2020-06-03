using System;

namespace ValidatePhoneNumber
{
    class Program
    {
        public static PhoneNumberRegex validatePhone;
        public static string[] valid = { "(84)-(0978489648)" };
        public static string[] invalid = { "(a4)-(0978489648)", "(84)-(097848964)" };
        static void Main(string[] args)
        {
            validatePhone = new PhoneNumberRegex();
            foreach (var item in valid)
            {
                Console.WriteLine($"{item} is {validatePhone.Validate(item)}");
            }
            foreach (var item in invalid)
            {
                Console.WriteLine($"{item} is {validatePhone.Validate(item)}");
            }
        }
    }
}
