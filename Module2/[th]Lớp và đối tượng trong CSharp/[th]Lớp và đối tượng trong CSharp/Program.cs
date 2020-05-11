using System;

namespace _th_Lớp_và_đối_tượng_trong_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width:");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            double height = Double.Parse(Console.ReadLine());
            RecTangle rectangle = new RecTangle(width,height);
            Console.WriteLine("Your Rectangle \n" + rectangle.ToString());
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
        }
    }
    class RecTangle
    {
        private double width, height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public RecTangle() { }
        public RecTangle(double width,double height)
        {
            this.width = width;
            this.height = height;
        }
        
        public double GetPerimeter()
        {
            return (width + height) * 2;
        }
        public double GetArea()
        {
            return width * height;
        }
        public override string ToString()
        {
            return $"Rectangle, width {width}, height {height}";
        }
    }
}
