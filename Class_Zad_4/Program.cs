using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            foreach (var item in test.Method())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class TestClass
    {
        public IEnumerable Method()
        {
            yield return "Hello World!";
            yield return "Hello World!";
            yield return "Hello World!";
            yield return "Hello World!";
            yield return "Hello World!";
            yield return "Hello World!";
            yield return "Hello World!";
            yield return "Hello World!";
            yield return "Hello World!";
            yield return "Hello World!";
            yield break;
        }
    }
}
