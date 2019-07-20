using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct;

            myClass.change = "Не изменено";
            myStruct.chance = "Не изменено";

            Console.WriteLine(myClass);
            Console.WriteLine(myStruct);

            ClassTaker(myClass);
            StruktTanker(myStruct);

            Console.WriteLine(myClass);
            Console.WriteLine(myStruct);

            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }

        static void StruktTanker(MyStruct myStruct)
        {
            myStruct.chance = "Изменено";
        }
    }
}
