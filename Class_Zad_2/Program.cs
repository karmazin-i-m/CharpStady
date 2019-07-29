using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1<Random> class1 = new Class1<Random>();

            class1.ShowCurentData();
            class1.SetPropsData(new Random((int)DateTime.Now.Ticks), new Random(DateTime.Now.Millisecond));

            Console.WriteLine(class1.PropertyA.Next());
            Console.WriteLine(class1.PropertyB.Next());

            class1.SetCurentDateTime();
            Console.WriteLine(class1.dateTime.NextDouble());

            Console.ReadKey();
        }
    }
    
}
