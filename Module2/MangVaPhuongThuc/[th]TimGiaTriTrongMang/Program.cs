using System;

namespace _th_TimGiaTriTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = { "Christan", "Micheal", "Camilla", "Siena", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter a name of student:");
            String inputName = Console.ReadLine();
            bool exits = false;
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].Equals(inputName))
                {
                    Console.WriteLine($"Vi tri cua {inputName} trong chuoi la {i}");
                    exits = true;
                    break;
                }
            }
            if (!exits)
            {
                Console.WriteLine($"Không tìm thấy {inputName} trong chuỗi");
            }

        }
    }
}
