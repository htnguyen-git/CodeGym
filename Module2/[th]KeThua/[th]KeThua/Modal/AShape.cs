using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace _th_KeThua.Modal
{
    abstract class AShape
    {
        private bool filled;
        private string color;

        public AShape()
        {
            filled = false;
            color = "green";
        }
        public AShape(bool filled, string color)
        {
            this.filled = filled;
            this.color = color;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        
        public override string ToString()
        {
            return $"A Shape with color {color} and {(filled ? "filled" : "not filled")}";
        }

    }
}
