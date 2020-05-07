using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BTVaTHNetCoreVaCShap
{
    static class SoNguyenTo
    {
        

        public static bool KiemTra(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number %i == 0 )
                {
                    return false;
                }
            }
            return true;
        }
        public static void NhoHon(int number)
        {
            
            string daySoNguyenTo = "";
            for (int j = 2; j <= number; j++)
            {
                if (KiemTra(j))
                {
                    daySoNguyenTo += j.ToString() + ", ";
                }
               
            }
            Console.WriteLine(daySoNguyenTo);
        }
    }
}
