using System;
using System.Threading;

namespace TImSoNguyenTo
{
    class Program
    {

        static void Main(string[] args)
        {
            LazyPrimeFactorization lz1 = new LazyPrimeFactorization("Threading1");
            OptimizedPrimeFactorization op1 = new OptimizedPrimeFactorization("Threading2");
            Thread thread1 = new Thread(lz1.Run);
            Thread thread2 = new Thread(op1.Run);
            thread1.Start();
            thread2.Start();
        }
    }
}
