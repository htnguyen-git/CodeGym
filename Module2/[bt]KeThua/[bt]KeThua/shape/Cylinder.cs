using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_KeThua.shape
{
    class Cylinder : Circle
    {
        public double Height { get; set; }
        public double TheTich { get => Area * Height; }

        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            Height = height;
        }

        public override string ToString()
        {
            return $"A Cylinder with height is {Height}, volume is {TheTich} from " +  base.ToString() ;
        }

    }
}
