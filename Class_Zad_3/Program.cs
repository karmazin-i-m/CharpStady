using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();

            figure.AddPoint(new Point(1, 2));
            System.Console.WriteLine(figure.GetFigureName);

            figure.AddPoint(new Point(3, 4));
            System.Console.WriteLine(figure.GetFigureName);

            figure.AddPoint(new Point(5, 6));
            System.Console.WriteLine(figure.GetFigureName);

            figure.AddPoint(new Point(7, 8));
            System.Console.WriteLine(figure.GetFigureName);

            figure.AddPoint(new Point(9, 10));
            System.Console.WriteLine(figure.GetFigureName);

            figure.AddPoint(new Point(11, 12));
            System.Console.WriteLine(figure.GetFigureName);

            Console.ReadKey();
        }
    }
}
