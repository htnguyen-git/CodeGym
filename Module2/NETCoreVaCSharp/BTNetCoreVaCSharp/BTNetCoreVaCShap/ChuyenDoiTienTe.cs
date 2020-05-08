using System;
using System.Collections.Generic;
using System.Text;

namespace BTVaTHNetCoreVaCShap
{
    class ChuyenDoiTienTe
    {
        private double VND;
        private double USD;
        private const double rate = 23000;

        
        public void SetUSD()
        {
            Console.WriteLine("Nhập số tiền USD");
            double.TryParse(Console.ReadLine(), out USD);
        }
        public double GetUSD()
        {
            return USD;
        }
        public double ConvertUSDtoVND(double USD)
        {
            return VND = rate * USD;
        }
        public void InTienVND()
        {
            Console.WriteLine($"{USD} USD = {VND} VND");
        }
    }
}
