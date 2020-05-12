using System;
using System.Collections.Generic;
using System.Text;

namespace _th_KeThua.Modal
{
    class Square : Rectangle
    {
        double side;
        
        public Square() { }
        public Square(double side) : base(side, side) { }
        public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

        public double GetSide()
        {
            return side;
        }
        public override string ToString()
        {
            return $"A square width side = {GetSide()}, which is a subclass of {base.ToString()} ";
        }

    }
}
