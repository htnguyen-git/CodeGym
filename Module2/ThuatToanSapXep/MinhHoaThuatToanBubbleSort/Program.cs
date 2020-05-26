using System;

namespace MinhHoaThuatToanBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,4,3,4,5,3,3};
            BubbleSort(a);
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

                // in ra màn hình trang thái hiện tại của mảng
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
