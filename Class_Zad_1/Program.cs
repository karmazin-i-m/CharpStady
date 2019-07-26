using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2<Class1> class2 = new Class2<Class1>();

            class1.ShowClassType();
            Console.WriteLine(class2.Prop);
            class2.ShowClassType();
            class2.ShowPropType();

            Console.ReadKey();
        }
    }
    interface IInt
    {
        void ShowClassType();
    }
    interface IInt<Y>
    {
        Y Prop { get; set; }

        void ShowPropType();
    }

    class Class1 : IInt
    {
        public void ShowClassType()
        {
            Console.WriteLine(typeof(Class1));
        }
    }

    class Class2<Y> : IInt, IInt<Y>
    {
        public Y Prop { get; set; }

        public void ShowClassType()
        {
            Console.WriteLine(typeof(Class2<Y>));
        }

        public void ShowPropType()
        {
            Console.WriteLine(typeof(Y));
        }
    }
}
