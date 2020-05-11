using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_MangVaPhuongThuc
{
    class MyArray
    {
        private int[] intArray;

        public MyArray() { }

        #region private
        int[] InsertIntArray(int[] arr, byte position, int value)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < position)
                {
                    newArr[i] = arr[i];
                }
                if (i == position)
                {
                    newArr[i] = value;
                }
                if (i > position)
                {
                    newArr[i] = arr[i - 1];
                }
            }
            return newArr;
        }
        int[] RemoveFromArray(int[] arr, int position)
        {
           
            if (position > arr.Length || position < 0)
            {
                Console.WriteLine($"0 <= position < {arr.Length}");
                Console.Read();
                RemoveFromArray(arr, position);
            }

            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < position; i++)
            {
                newArr[i] = arr[i];
            }
            for (int i = position; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }
            return newArr;
        }    
        int SearchInArray(int value)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        int MinInArray()
        {
            int min = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (min > intArray[i])
                {
                    min = intArray[i];
                }
            }
            return min;
        }
       
        #endregion
        #region public
        public int[] GetArray()
        {
            return intArray;
        }
        public void NhapIntArray()
        {
            Console.Write("Size of interger array : ");
            int size = int.Parse(Console.ReadLine());
            intArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Value of element {i} : ");
                intArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("input is end!");
        }
        public void ShowIntArray()
        {
            Console.WriteLine("List element of interger array");
            foreach (var item in intArray)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        public void InsertElementToIntArray()
        {
            Console.Write("Position to insert : ");
            byte position = byte.Parse(Console.ReadLine());
            if (position > intArray.Length || position < 0)
            {
                Console.WriteLine("Can not insert!");
                InsertElementToIntArray();
                return;
            }
            Console.Write("Value of element : ");
            int intValue = int.Parse(Console.ReadLine());

            // Create new array to resize
            intArray = InsertIntArray(intArray, position, intValue);
        }
        public void RemoveElementFromIntArray()
        {
            Console.Write("Position to remove : ");
            int pos = int.Parse(Console.ReadLine());
            if (pos < 0 || pos > intArray.Length)
            {
                Console.WriteLine("Not found");
            }
            intArray = RemoveFromArray(intArray, pos);
        }
        public void GopMang(int[] arr2)
        {
            int[] arr3 = new int[intArray.Length + arr2.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                arr3[i] = intArray[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[intArray.Length + i] = arr2[i];
            }
            intArray = arr3;
        }
        public void PrintMin()
        {
            Console.WriteLine("Gía trị nhỏ nhất trong mảng : " + MinInArray());
        }
        #endregion

        #region static

        #endregion

    }
}
