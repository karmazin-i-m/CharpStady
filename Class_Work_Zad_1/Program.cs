using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_Zad_1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] array =
            {
                "Моя кошка любит корм",
                "Сколько гор во всем мире?",
                "Монте-Карло город казино",
                "Дорога в никуда",
                "Моя мама печет пироги",
                "Масик кличка моего кота"
            };

            Predicate predicate = delegate (string @string)
            {
                if (@string.ToArray()[0] == 'М')
                {
                    for (int j = 0; j < @string.Length; j++)
                    {
                        if (@string.ToArray()[j] == 'р' && @string.ToArray()[j - 1] == 'о')
                        {
                            return true;
                        }
                    }
                }
                return false;
            };

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Shows(predicate);
            }

            Console.ReadKey();
        }

    }
    delegate bool Predicate(string str);
    static class Extension
    {
        public static void Shows(this string str, Predicate predicate)
        {
            if (predicate(str))
            {
                Console.WriteLine(str);
            }
        }
    }
}
