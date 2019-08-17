using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 testClass1 = new TestClass1();
            TestClass2 testClass2 = new TestClass2();

            Console.WriteLine(testClass1.GetHashCode());
            Console.WriteLine(testClass2.GetHashCode());

            Console.ReadKey();
        }
    }
    class TestClass1
    {
        public override int GetHashCode()
        {
            return Int32.Parse($"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}");
        }
    }
    class TestClass2
    {
        public override int GetHashCode()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            return random.Next(Int32.MinValue, Int32.MaxValue);
        }
    }

}
