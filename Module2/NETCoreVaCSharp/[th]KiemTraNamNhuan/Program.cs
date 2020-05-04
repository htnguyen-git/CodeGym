using System;

namespace _th_KiemTraNamNhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Kiem tra nam nhuan");
            year = int.Parse(Console.ReadLine());
            bool isDiviveBy4 = (year % 4 == 0);
            bool leafYear = false;
            if (isDiviveBy4)
            {
                bool isDivineBy100 = (year % 100 ==0);
                if (isDivineBy100)
                {
                    leafYear = true;
                }
            }
            if (leafYear)
            {
                Console.WriteLine("la Nam nhuan");
            }
            else
            {
                Console.WriteLine("Khong phai nam nhuan");
            }

        }
    }
}
