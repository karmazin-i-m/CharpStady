using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_Dop
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            System.Console.WriteLine(notebook);

            notebook = new Notebook("K53SC", "ASUS", 21000);
            System.Console.WriteLine(notebook);

            System.Console.ReadKey();
        }
    }
}
