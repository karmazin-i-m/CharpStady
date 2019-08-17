using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(12);
            Circle circle1 = new Circle(1);

            Console.WriteLine(circle.Arial);
            Console.WriteLine(circle1.Arial);

            circle += circle1;

            Console.WriteLine(circle.Arial);
            Console.ReadKey();
        }
    }

    struct Circle
    {
        private double radius;
        private double arial;

        public Circle(double radius)
        {
            this.radius = radius;
            this.arial = Math.PI * Math.Pow(radius,2);
        }

        public double Radius => radius;
        public double Arial => arial;

        public static Circle operator +(Circle circle1, Circle circle2)
        {
            return new Circle(Math.Sqrt(((circle1.arial+circle2.arial) / Math.PI)));
        }
    }
}
