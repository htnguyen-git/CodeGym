using System;

namespace CaiDatThuatToanSapXepNoiBot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 640, 4, 250, -12, 232, 11, -90 };
            BubbleSort(arr);
            string s = "";
            foreach (var element in arr)
            {
                s += element + " ";
            }
            Console.WriteLine(s);
        }
        static void BubbleSort(int[] arr)
        {
            int i, j, temp;
            int n = arr.Length;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
    }
}
