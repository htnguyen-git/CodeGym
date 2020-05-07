using System;
using System.Collections.Generic;
using System.Text;

namespace BTVaTHNetCoreVaCShap
{
    static class Menu
    {
        static string[] mucLucChinh = {"Ứng dụng đọc số thành chữ ",
                            "Hiển thị lời chào",
                            "Hiển thị số nguyên tố nhỏ hơn 100",
                            "Thiết kế menu cho ứng dụng",
                            "Tính tiền lãi cho vay",
                            "Tìm ước số lớn nhất",
                            "Hiển thị các loại hình",
                            "Hiển thị 20 số nguyên tố đầu tiên",
                            "Chuyển đổi tiền tệ",
                            };
        public static void ShowMenuChinh()
        {
            for (int i = 0; i<mucLucChinh.Length ; i++)
            {
                Console.WriteLine($"*\t {i}.{mucLucChinh[i]}");
            }
        }
    }
}
