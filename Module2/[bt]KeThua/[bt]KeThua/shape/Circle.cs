using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _bt_KeThua.shape
{
    class Circle
    {
        public double Radius { get; set; }
        public double Area { get => Radius * Radius * Math.PI; }
        public string Color { get; set; }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        public override string ToString()
        {
            return $"A circle, with area is {Radius}, and color is {Color}";
        }




    }
}
