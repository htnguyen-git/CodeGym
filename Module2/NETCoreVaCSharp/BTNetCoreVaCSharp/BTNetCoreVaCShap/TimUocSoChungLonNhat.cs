using System;
using System.Collections.Generic;
using System.Text;

namespace BTVaTHNetCoreVaCShap
{
    class TimUocSoChungLonNhat
    {
        int a, b;
        public void Nhap()
        {
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void TinhUocSo()
        {
            if (a == 0 || b == 0) Console.WriteLine("No greatest common factor");
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine("Ước số chung lớn nhất " + a);
            Console.Read();
        }
    }
}
