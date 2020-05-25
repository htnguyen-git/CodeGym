using System;

namespace _bt_TimKiemNhiPhanSuDungDeQuy
{
    class Program
    {
        static int[] list = { 2, 4, 7, 10, 11, 45, 50, 59, 60, 66, 69, 70, 79 };
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(list,0,list.Length-1, 2));       /* 0 */
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 11));     /* 4 */
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 79));     /*12 */
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 1));       /*-1 */
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 5));       /*-1 */
            Console.WriteLine(BinarySearch(list, 0, list.Length - 1, 80));
        }
        static int BinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);

                return BinarySearch(arr, mid + 1, r, x);
            }

            return -1;
        }
    }
}
