using System;
using System.Collections.Generic;

namespace _bt_NetCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("lion");
            animals.Add("cat");
            animals.Add("dog");
            animals.Add("elephant");

            Console.WriteLine("Danh sach hien tai");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            animals.Sort();
            Console.WriteLine();
            Console.WriteLine("Danh sach sau khi sort");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            // xoa phan tu dog
            Console.WriteLine();
            animals.Remove("dog");
            Console.WriteLine("Danh sach sau khi xoa dog");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
