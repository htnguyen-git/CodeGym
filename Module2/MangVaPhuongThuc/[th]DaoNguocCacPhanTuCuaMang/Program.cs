using System;

namespace _th_DaoNguocCacPhanTuCuaMang
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai báo biến, nhập và kiểm tra mảng
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Nhập kích thước mảng: ");
                size = int.Parse(Console.ReadLine());
                if (size >20)
                {
                    Console.WriteLine("Kích thước mảng từ 0-20");
                }
            } while (size >20);


            // Nhập giá trị cho các phần tử của mảng
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine($"Nhap gia tri cho phan tu {i} :");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            // In ra mảng đã nhập 
            Console.WriteLine("Mang da nhap :");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + "\t");
            }
            // Đảo ngược mảng đã nhập
            Console.WriteLine("Mang sau khi dao nguoc");
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[array.Length-1 -k] + "\t");
            }

        }
    }
}
