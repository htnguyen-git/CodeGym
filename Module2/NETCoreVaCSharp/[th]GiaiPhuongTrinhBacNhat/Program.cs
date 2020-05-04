using System;

namespace _th_GiaiPhuongTrinhBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a * x + b = 0");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine($"Phuong trinh co 1 nghiem x = {-b / a}");
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("Bất cứ giá trị nào của x đều đúng");
                }
                else
                {
                    Console.WriteLine("Không đúng với bất kỳ giá trị nào của x");
                }
            }

        }
    }
}
