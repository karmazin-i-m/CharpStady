using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_2
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

            for (int i = 0; i < 10; i++)
            {
                list.RemoveAt(i);
            }
            Console.WriteLine(list);
            Console.ReadKey();
        }
    }
}
