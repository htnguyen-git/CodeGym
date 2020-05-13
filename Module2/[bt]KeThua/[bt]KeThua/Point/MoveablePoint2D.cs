using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _bt_KeThua.Point
{
    class MoveablePoint2D : Point2D
    {
        private float xSpeed = 0.0f;
        private float ySpeed = 0.0f;

        public MoveablePoint2D()
        {
        }
        public MoveablePoint2D(float x, float y, float xSpeed, float ySpeed) : base(x, y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public float GetXspeed()
        {
            return xSpeed;
        }
        public void SetXspeed(float xSpeed)
        {
            this.xSpeed = xSpeed;
        }
        public float GetYspeed()
        {
            return ySpeed;
        }
        public void SetYspeed(float ySpeed)
        {
            this.ySpeed = ySpeed;
        }
        public void SetSpeed(float xSpeed, float ySpeed)
        {
            SetXspeed(xSpeed); SetYspeed(ySpeed);
        }
        public float[] GetXYspeed()
        {
            float[] xySpeed = new float[2] { GetXspeed(), GetYspeed() };
            return xySpeed;
        }
        public void SetXYSpeed(float xSpeed, float ySpeed)
        {
            SetXspeed(xSpeed);
            SetYspeed(ySpeed);
        }
        public void Move()
        {
            SetX(GetX() + GetXspeed());
            SetY(GetY() + GetYspeed());
        }
    }
}
