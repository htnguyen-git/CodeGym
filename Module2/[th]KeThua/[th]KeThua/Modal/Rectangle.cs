using System;
using System.Collections.Generic;
using System.Text;

namespace _th_KeThua.Modal
{
    class Rectangle : AShape
    {
        private double width, length;

        public Rectangle()
        {
            width = length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle (double width, double length, string color, bool filled) : base(filled, color)
        {
            this.width = width;
            this.length = length;
        }

        public override double GetArea()
        {
            return width * length;
        }

        public override double GetPerimeter()
        {
            return (width + length) * 2;
        }
        public double GetWidth()
        {
            return width;
        }
        public double GetLength()
        {
            return length;
        }
        public override string ToString()
        {
            return $"A rectangle, width = {GetWidth()} , length = {GetLength()} , which is subclass of {base.ToString()} ";
        }
    }
}
