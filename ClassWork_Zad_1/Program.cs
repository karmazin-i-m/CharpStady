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
            List<int> list = new List<int>();
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 100));
            }
            Console.WriteLine(list);

            foreach (int element in list)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
