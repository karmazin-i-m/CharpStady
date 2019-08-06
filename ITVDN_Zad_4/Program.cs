using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("sfasfas");
            list.Add(123);
            list.Add(new System.Random());

            foreach (object obj in list)
            {
                System.Console.WriteLine(obj.ToString());
            }

            System.Console.ReadKey();
        }
    }
}
