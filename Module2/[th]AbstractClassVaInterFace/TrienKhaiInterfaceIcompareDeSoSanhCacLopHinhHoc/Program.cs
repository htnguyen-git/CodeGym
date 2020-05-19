using _th_KeThua.Modal;
using System;
using System.Collections.Generic;
using TrienKhaiInterfaceIcompareDeSoSanhCacLopHinhHoc.ChucNang;

namespace TrienKhaiInterfaceIcompareDeSoSanhCacLopHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(3.6));
            circles.Add(new Circle(0));
            circles.Add(new Circle(3.5,"Idigo",true));

            Console.WriteLine("Truoc khi Sort : ");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.WriteLine("Sau khi sort : ");
            IComparer<Circle> circleComparator = new CircleCompare();
            circles.Sort(circleComparator);
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

        }
    }
}
