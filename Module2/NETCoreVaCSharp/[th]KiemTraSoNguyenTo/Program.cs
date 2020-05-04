using System;

namespace _th_KiemTraSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập giá trị từ bàn phím và gán nó cho biến number
            int number;
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            //Kiểm tra số nguyên tố
            if (number < 2)
            {
                Console.WriteLine(number + " không phải số nguyên tố");
            }
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime");
                }
            }


        }
    }
}
