using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_KeThua.Point
{
    class Point2D
    {
        private float x = 0.0f;
        private float y = 0.0f;

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Point2D() { }

        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetX()
        {
            return x;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public float GetY()
        {
            return y;
        }
        public void SetXY(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY()
        {
            float[] xy = new float[2] { x, y };
            return xy;
        }
        public override string ToString()
        {
            return $"(x,y) = {GetX()}, {GetY()}";
        }
    }
}
