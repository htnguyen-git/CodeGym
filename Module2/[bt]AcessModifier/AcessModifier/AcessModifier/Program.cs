using System;

namespace AcessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cc1 = new Circle();
            Console.WriteLine(cc1.GetColor());
            Console.WriteLine(cc1.GetRadius());
            Console.WriteLine(cc1.GetArea());
        }
    }
}
