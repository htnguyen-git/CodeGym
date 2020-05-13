using _bt_KeThua.Point;
using _bt_KeThua.shape;
using System;
using System.ComponentModel.Design;
using System.Text;

namespace _bt_KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Show();
        }

        static string[] list = 
        {
            "Lớp Circle và lớp Cylinder",
            "Lớp point2D và lớp point3D",
            "Lớp point và moveablePoint",
            "Thiết kế và triển khai lớp Triangle"
        };
        
        static void Show()
        {
            Console.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"{i}. {list[i]}");
            }

            Select();
        }
        static void Select()
        {
            Console.Write($"(0-3) to select, (q) to quit : ");
            string selected = Console.ReadLine();
            switch (selected)
            {
                case "0":
                    Circle cc = new Circle(5,"blue");
                    Console.WriteLine(cc.ToString());
                    Console.ReadKey();

                    Cylinder cl = new Cylinder(6,"blue", 8);
                    Console.WriteLine(cl.ToString());
                    Console.ReadKey();
                    break;

                case "1":
                    Console.WriteLine("Lớp point 2D");
                    Point2D p2d1 = new Point2D();
                    p2d1.SetX(5);
                    p2d1.SetY(6);
                    Console.WriteLine(p2d1.ToString());
                    Console.ReadKey();

                    Point2D p2d2 = new Point2D(10,11);
                    Console.WriteLine(p2d2.ToString());
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Lớp 3D");
                    Point3D p3d1 = new Point3D(5,6,7);
                    Console.WriteLine(p3d1.ToString());

                    break;

                case "2":
                    Console.WriteLine("Lớp point");
                    Point2D p2d = new Point2D(5, 7);
                    Console.WriteLine(p2d.ToString());
                    Console.ReadKey();

                    Console.WriteLine("Lớp Moveablepoint");
                    MoveablePoint2D mPoint = new MoveablePoint2D(5, 6, 7, 8);
                    Console.WriteLine(mPoint.ToString());
                    mPoint.Move();
                    Console.WriteLine("Sau khi move");
                    Console.WriteLine(mPoint.ToString());
                    Console.ReadKey();

                    MoveablePoint2D mPoint2 = new MoveablePoint2D();
                    mPoint2.SetXY(5,7);
                    Console.WriteLine(mPoint2.ToString());
                    mPoint2.SetXYSpeed(2, 3);
                    
                    Console.WriteLine("Move");
                    mPoint2.Move();
                    Console.WriteLine(mPoint2.ToString());

                    break;
            }
            Console.ReadKey();

            Show();
        }
    }
}
