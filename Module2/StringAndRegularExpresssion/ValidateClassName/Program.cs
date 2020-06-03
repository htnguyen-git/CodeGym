using System;

namespace ValidateClassName
{
    class Program
    {
        static ClassNameRegex classNameRegex;
        static string[] validClass = { "C0318G" };
        static string[] invalidClass = { "M0318G", "P0323A" };
        static void Main(string[] args)
        {
            classNameRegex = new ClassNameRegex();
            foreach (var item in validClass)
            {
                Console.WriteLine($"{item} is {classNameRegex.Validate(item)}");
            }
            foreach (var item in invalidClass)
            {
                Console.WriteLine($"{item} is {classNameRegex.Validate(item)}");
            }
        }
    }
}
