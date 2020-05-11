using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_LopVaDoiTuongCSharp
{
    class Fan
    {
        const byte SLOW = 1;
        const byte MEDIUM = 2;
        const byte FAST = 3;
        int speed = SLOW;
        bool on = false;
        private double radius = 5;
        private string color = "blue";

        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public Fan() { }

        public override string ToString()
        {
            if (on)
            {
                return $"Fan is on, speed : {speed} , color : {color} , radius : {radius}";
            }
            else
            {
                return $"Fan is off";
            }

        }
    }
}
