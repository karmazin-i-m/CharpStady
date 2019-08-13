using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_DopZad
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            IEnumerable<int> enumerable = Method((i) => i % 2 == 0, array);

            List<int> list = new List<int>(enumerable);

            foreach(var element in list)
            {
                Console.Write(element+" ");
            }

            Console.ReadKey();
        }

        static IEnumerable<T> Method<T>(Predicate<T> predicate, params T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (predicate.Invoke(items[i]))
                {
                    yield return items[i];
                }
            }
            yield break;
        }
    }
}
