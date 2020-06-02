using System;
using System.Collections.Generic;
using System.Text;

namespace TaoThreadingDonGian
{
    class NumberGenerator
    {
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"hashCode : {this.GetHashCode()} \t {i}");
                System.Threading.Thread.Sleep(500);
            }
        }

    }
}
