using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_3
{
    class MyClass
    {
        public string change;

        public override string ToString()
        {
            Console.Write(change + " ");
            return base.ToString();
        }
    }

    struct MyStruct
    {
        public string chance;

        public override string ToString()
        {
            Console.Write(chance + " ");
            return base.ToString();
        }
    }
}
