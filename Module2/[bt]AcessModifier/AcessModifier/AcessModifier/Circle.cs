using System;
using System.Collections.Generic;
using System.Text;

namespace AcessModifier
{
    class Circle
    {
        private double radius = 1;
        private string color = "red";

        public Circle() { }
        public Circle(double r)
        {
            radius = r;
        }

        public double GetRadius()
        {
            return radius;
        }
        public string GetColor()
        {
            return color;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
