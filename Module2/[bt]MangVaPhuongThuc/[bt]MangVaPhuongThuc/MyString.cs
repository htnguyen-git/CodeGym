using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_MangVaPhuongThuc
{
    class MyString
    {
        string str;

        public void NhapChuoi()
        {
            Console.WriteLine("Nhập chuỗi");
            str = Console.ReadLine();
        }
        public void HienChuoi()
        {
            Console.WriteLine(str);
        }
        public void InSoLanXuatHien(char c)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"Số lần xuất hiện của {c} là : {count}");
        }
    }
}
