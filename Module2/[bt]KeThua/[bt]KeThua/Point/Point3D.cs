using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_KeThua.Point
{
    class Point3D : Point2D
    {
        float z = 0.0f;

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public Point3D() { }

        public float GetZ()
        {
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public float[] GetXYZ()
        {
            float[] xyz = new float[3] { GetX(), GetY(), GetZ() };
            return xyz;
        }
        public void SetXYZ(float x, float y, float z)
        {
            SetX(x);
            SetY(y);
            SetZ(z);
        }
        public override string ToString()
        {
            return $"(x,y,z) = {GetX()}, {GetY()}, {GetZ()}";
        }

    }
}
