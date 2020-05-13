using System;
using System.Collections.Generic;
using System.Text;

namespace _th_KeThua.Modal
{
    class Triangle : AShape
    {
        public double Sidea { get; set; } = 1.0;
        public double Sideb { get; set; } = 1.0;
        public double Sidec { get; set; } = 1.0;
        public double Perimeter { get => Sidea + Sideb + Sidec; }
        public double HalfPerimeter { get => Perimeter / 2; }
        public double Area { get =>Math.Sqrt( HalfPerimeter * (HalfPerimeter-Sidea) * (HalfPerimeter - Sideb) * (HalfPerimeter - Sidec) ); }
        
        public Triangle() { }
        public Triangle(double sidea, double sideb, double sidec)
        {
            Sidea = sidea;
            Sideb = sideb;
            Sidec = sidec;
        }

       
        public override double GetArea()
        {
            return Area;
        }

        public override double GetPerimeter()
        {
            return Perimeter;
        }

        public override string ToString()
        {
            return base.ToString() + $"And this is a triangle with side (a,b,c) = ({Sidea},{Sideb},{Sidec}), perimeter {GetPerimeter()}, area {GetArea()}";
        }
    }
}
