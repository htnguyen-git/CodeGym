using System;

namespace KhoiTaoHamSuDungGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "asdfasdf";
            string y = "asdfasdf";
            bool a = MyGeneric<string>.SoSanh(x, y);
            Console.WriteLine(a);

            int t = 6;
            int k = 10;
            bool b = MyGeneric<int>.SoSanh(t,k);
            Console.WriteLine(b);
        }
    }
}
