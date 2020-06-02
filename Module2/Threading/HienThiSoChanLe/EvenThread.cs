using System;
using System.Collections.Generic;
using System.Text;

namespace HienThiSoChanLe
{
    class EvenThread
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(10);
                }
            }
        }
    }
}
