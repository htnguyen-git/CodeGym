using System;
using System.Text;

namespace AbstractClassVaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Show();
                Select();
            }
            
        }
        static string[] list = new string[5]
       {
            "Lớp animal và Interface Edible",
            "Triển khai Interface Icompare cho các lớp hình học",
            "Triển khai Interface IComparible cho các lớp hình học",
            "Triển khai Interface Resize able cho các lớp hình học",
            "Triển khai Interface Icolorale cho các lớp hình học"
       };
        public static void Show()
        {
            Console.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"{i }. {list[i]}");
            }
        }
        public static void Select()
        {
            Console.Write($"(0-{list.Length}). (q) to quit. Option: ");
            string selected = Console.ReadLine();
            switch (selected)
            {
                case "q":
                    Environment.Exit(0);
                    break;
                case "0":
                    AAnimal[] animals = new AAnimal[2];
                    animals[0] = new Tiger();
                    animals[1] = new Chicken();
                    foreach (AAnimal animal in animals)
                    {
                        Console.WriteLine(animal.MakeSound());
                    }

                    AFruit[] fruits = new AFruit[2];
                    fruits[0] = new Orange();
                    fruits[1] = new Apple();
                    foreach (AFruit fruit in fruits)
                    {
                        Console.WriteLine(fruit.HowtoEat());
                    }
                    break;
                case "1":
                    // CircleComparer Test:

                    Circle[] circles = new Circle[3];
                    circles[0] = new Circle(3.6);
                    circles[1] = new Circle();
                    circles[2] = new Circle(3.5, "indigo", false);

                    Console.WriteLine("Pre-sorted:");
                    foreach (Circle circle in circles)
                    {
                        Console.WriteLine(circle);
                    }

                    IComparable<Circle> circleComparator = new CircleComparator();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
