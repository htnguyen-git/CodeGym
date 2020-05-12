using System;
using System.Collections.Generic;
using System.Text;

namespace _th_KeThua.Modal
{
    class Circle : AShape
    {
        double radius;

        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(filled, color) 
        {
            this.radius = radius;
        }


        public override double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public override double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override string ToString()
        {
            return  $"A cirle with radius {radius}, which a subclass of " + base.ToString() ;
        }

    }

}
