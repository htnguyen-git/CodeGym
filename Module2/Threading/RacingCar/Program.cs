using System;
using System.Threading;

namespace RacingCar
{
    class Program
    {
        static void Main(string[] args)
        {
			Car carA = new Car("A");
			Car carB = new Car("B");
			Car carC = new Car("C");

			Thread thread1 = new Thread(carA.Run);
			Thread thread2 = new Thread(carB.Run);
			Thread thread3 = new Thread(carC.Run);
			thread3.Priority = ThreadPriority.Highest;
			Console.WriteLine("Distance: 100KM");
			thread1.Start();
			thread2.Start();

			thread3.Start();


			Console.ReadLine();
		}
    }
}
