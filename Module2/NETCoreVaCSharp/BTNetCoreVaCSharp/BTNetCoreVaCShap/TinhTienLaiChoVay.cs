using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BTVaTHNetCoreVaCShap
{
    class TinhTienLaiChoVay
    {
        double money;
        int month;
        double intersetRate;

        public void NhapGiaTri()
        {
            Console.WriteLine("Nhập số tiền");
            money = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lãi suất %");
            intersetRate = double.Parse(Console.ReadLine());
        }
        public void InLaiSuat()
        {
            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate / 100) / 12 * 3;
            }
            Console.WriteLine("Total of interset: " + totalInterset);
        }
    }
}
