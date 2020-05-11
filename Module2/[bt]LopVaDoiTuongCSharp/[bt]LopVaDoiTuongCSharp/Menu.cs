using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_LopVaDoiTuongCSharp
{
    static class Menu
    {
        static string[] list = { "Xây dựng lớp phương trình bậc 2", "Xây dựng lớp StopWatch", "Xây dựng lớp Fan" };

        public static void Show()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"{i}. {list[i]}");
            }
            
        }
    }
}
