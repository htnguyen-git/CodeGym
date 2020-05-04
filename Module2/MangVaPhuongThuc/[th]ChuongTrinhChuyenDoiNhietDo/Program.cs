using System;

namespace _th_ChuongTrinhChuyenDoiNhietDo
{
    class Program
    {
        static void Main(string[] args)
        {
            double farenheit;
            double celcius;
            int choice;
            // In menu, cho phép người dùng nhập kết quả
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Farenheit to Celcius");
                Console.WriteLine("2. Celcius to Farenheit");
                Console.WriteLine("0. Exit");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Farenheit :");
                        farenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"Celcius: {FarenheitToCelcius(farenheit)}");
                        break;
                    case 2:
                        Console.Write("Celcius :");
                        celcius = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"Farenheit: {CelciusToFarenheit(celcius)}");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }
        public static double CelciusToFarenheit(double celcius) => (9.0 / 5 * celcius) + 32;
        public static double FarenheitToCelcius(double farenheit) => (5.0 / 9) * (farenheit - 32);
    }
}
