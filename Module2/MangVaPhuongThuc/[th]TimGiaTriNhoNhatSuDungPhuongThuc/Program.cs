using System;

namespace _th_TimGiaTriNhoNhatSuDungPhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11 };
            Console.WriteLine($"Phan tu nho nhat trong mang nam o vi tri: {MinValue(arr)}");
        }
        public static int MinValue(int[] array)
        {

            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
