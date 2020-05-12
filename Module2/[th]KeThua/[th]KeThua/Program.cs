using _th_KeThua.Modal;
using System;

namespace _th_KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cc = new Circle(15,"blue",true);
            Console.WriteLine($"Dien tich hinh tron {cc.GetArea()}");
            Console.WriteLine($"Chu vi hinh tron {cc.GetPerimeter()}");
            Console.WriteLine(cc.ToString());
            Console.ReadKey();

            Rectangle rtg = new Rectangle(2.3, 5.8, "orange", true);
            Console.WriteLine($"Dien tich hinh chu nhat{rtg.GetArea()}");
            Console.WriteLine($"Chu vi hinh chu nhat{rtg.GetPerimeter()}");
            Console.WriteLine(rtg.ToString());
            Console.ReadKey();

            Square sqr = new Square(3.8, "blue", true);
            Console.WriteLine($"Dien tich hinh vuong{sqr.GetArea()}");
            Console.WriteLine($"Chu vi hinh vuong{sqr.GetPerimeter()}");
            Console.WriteLine(sqr.ToString());
            Console.ReadKey();

        }
    }
}
