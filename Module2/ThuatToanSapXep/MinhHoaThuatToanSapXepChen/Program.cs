using System;

namespace MinhHoaThuatToanSapXepChen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 4, 2, 1, 3, 4 };
            InsertionSort(arr);
        }
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                string s = "";
                foreach (var element in arr)
                {
                    s += element + " ";
                }
                Console.WriteLine(s);
            }
        }
    }
}
