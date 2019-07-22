using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_3
{
    class Program
    {
        delegate int RandomInt();
        delegate int MidleRandomInt(RandomInt[] randoms);
        static void Main(string[] args)
        {
            RandomInt randomer = delegate
            {
                Random random = new Random(DateTime.Now.Millisecond);
                return random.Next(0,1000);
            };

            RandomInt[] randome = { randomer, randomer, randomer, randomer, randomer };

            MidleRandomInt result = delegate (RandomInt[] randoms)
            {
                int res = 0;
                for (int i = 0; i < randoms.Length; i++)
                {
                    res += randoms[i].Invoke();
                }
                res /= randoms.Length;
                return res;
            };

            Console.WriteLine(result(randome));
            Console.ReadKey();
        }
    }
}
