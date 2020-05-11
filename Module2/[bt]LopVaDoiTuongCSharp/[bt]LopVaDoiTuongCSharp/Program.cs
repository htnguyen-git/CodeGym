using System;
using System.Text;

namespace _bt_LopVaDoiTuongCSharp
{
    class Program
    {
        static string inp;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Show();
        }
        static void Show()
        {
            Console.Clear();
            Console.WriteLine("Menu bài tập Lớp và đối tượng");
            Menu.Show();
            Select();
        }
        static void Select()
        {
            Console.Write("(0-3) to select, (q) to quit. Option: ");
            inp = Console.ReadLine();
            switch (inp)
            {
                case "q":
                    Environment.Exit(0);
                    break;
                case "0":
                    var ptb2 = new PhuongTrinhBac2();
                    Console.WriteLine(ptb2.ToString());
                    ptb2.Nhap();
                    ptb2.TinhDelta();
                    ptb2.InKetQuaTheoDelta();
                    break;
                case "1":
                    var stopWatch = new StopWatch();
                    stopWatch.ShowTime();
                    stopWatch.StartTime();
                    stopWatch.EndTime();
                    stopWatch.GetElapsedTime();
                    break;
                case "2":
                    Fan fan1 = new Fan();
                    fan1.Speed = 3;
                    fan1.Radius = 10;
                    fan1.Color = "yellow";
                    fan1.On = true;

                    Fan fan2 = new Fan();
                    fan2.Speed = 2;
                    fan2.Radius = 5;
                    fan2.Color = "Blue";
                    fan2.On = false;
                    Console.WriteLine("Trạng thái quạt 1");
                    Console.WriteLine( fan1.ToString());
                    Console.WriteLine("Trạng thái quạt 2");
                    Console.WriteLine( fan2.ToString());

                    break;
            }
            Console.ReadKey();
            Show();
        }
    }
}
