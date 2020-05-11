using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_MangVaPhuongThuc
{
    class Menu
    {
        readonly static string[] list = {  "Thêm phần tử vào mảng",
                                    "Xóa phần tử khỏi mảng",
                                    "Tìm phần tử lớn nhất trong mảng 2 chiều",
                                    "Gộp mảng",
                                    "Tìm giá trị nhỏ nhất trong mảng",
                                    "Tính tổng các số ở một cột cố định",
                                    "Đếm số lần xuất hiện của ký tụ trong chuỗi",
                                    "Mảng 2 chiều, tính tổng các số ở đường chéo chính ma trận vuông"};
        public static void Show()
        {
            Console.WriteLine("Các bài tập mảng và phương thức Module 2");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"*\t{i}. {list[i]} ");
            }
        }
    }
}
