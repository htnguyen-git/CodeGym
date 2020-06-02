using System;
using System.Threading;

namespace HienThiSoChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            OddThread ot = new OddThread();
            EvenThread et = new EvenThread();
            Thread th1 = new Thread(ot.Run);
            Thread th2 = new Thread(et.Run);
            th1.Start();
            th2.Start();
        }
    }
}
