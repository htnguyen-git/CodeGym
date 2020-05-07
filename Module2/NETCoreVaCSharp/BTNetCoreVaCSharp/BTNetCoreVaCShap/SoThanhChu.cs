namespace BTVaTHNetCoreVaCShap
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices.ComTypes;
    using System.Text;

    static class SoThanhChu
    {
        static int SoLuongSo(int number, int soluongSo = 1)
        {
            if (number /10 > 0)
            {
                return SoLuongSo(number / 10, soluongSo + 1);
            }
            return soluongSo;
        }
        static string ChuCuaSo(int number)
        {
            string s = "";
            switch (number)
            {
                case 1:
                    s = "một";
                    break;
                case 2:
                    s = "hai";
                    break;
                case 3:
                    s = "ba";
                    break;
                case 4:
                    s = "bốn";
                    break;
                case 5:
                    s = "năm";
                    break;
                case 6:
                    s = "sáu";
                    break;
                case 7:
                    s = "bảy";
                    break;
                case 8:
                    s = "tám";
                    break;
                case 9:
                    s = "chín";
                    break;
                default:
                    break;
            }
            return s;
        }
        public static void Doc(int number)
        {
            string s = "";
            int i = SoLuongSo(number);
            if (i > 3)
            {
                s = "Ngoài vùng đọc được";
            }
            
            Console.WriteLine($"{number} : {s}");
        }
    }
}
