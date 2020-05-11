using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_LopVaDoiTuongCSharp
{
    class PhuongTrinhBac2
    {
        private double a, b, c;
        private double delta;
        
        public void Nhap()
        {
            Console.Write("Enter a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter c : ");
            c = double.Parse(Console.ReadLine());
        }
        public void TinhDelta()
        {
            delta = b * b - 4 * a * c;  
        }
        public void InKetQuaTheoDelta()
        {
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            if (delta == 0)
            {
                Console.WriteLine($"Phương trình một nghiệm : x = {-b / (2 * a)}");
            }
            if (delta > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt");
                Console.WriteLine($"x1 = {(- b + delta)/ (2 * a)}");
                Console.WriteLine($"x2 = {(-b - delta) / (2 * a)}");
            }
        }
        public override string ToString()
        {
            return "Giải phương trình bậc 2. a * x^2 + b * x + c = 0";
        }
    }
}
