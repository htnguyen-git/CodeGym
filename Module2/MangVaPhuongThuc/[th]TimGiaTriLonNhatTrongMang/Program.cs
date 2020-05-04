using System;

namespace _th_TimGiaTriLonNhatTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến
            int size;
            int[] arr;
            // Nhập và kiểm tra kích thước mảng;
            do
            {
                Console.WriteLine("Nhap kich thuoc mang:");
                size = Int16.Parse(Console.ReadLine());
                if (size >20)
                {
                    Console.WriteLine("Kich thuoc mang khong qua 20");
                }
            } while (size >20);

            // Nhập giá trị cho từng phần tử của mảng 
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Phan tu thu {i} la : ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            // In ra các phần tử đã nhập
            Console.WriteLine("Cac phan tu cua mang : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            // Duyệt các phần tử trong mảng để tìm giá trị lớn nhất
            int max = arr[0];
            int index = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > max)
                {
                    max = arr[j];
                    index = j;
                }
            }
            Console.WriteLine($"Gia tri lon nhat trong cac phan tu da nhap la : {max} , o vi tri : {index}");
        }
    }
}
