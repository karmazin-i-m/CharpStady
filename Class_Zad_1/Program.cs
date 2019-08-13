using System;
using System.Collections;
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

            // Классную работу задание 2 реализовано в ClassWork_Zad_1
            TestClass test = new TestClass(10);

            foreach (var element in test)
            {
                Element elem = (Element)element;
                Console.WriteLine($"A: {elem.A} B: {elem.B} C: {elem.C}");
            }

            Console.WriteLine(new string('-', 80));

            foreach (var element in test)
            {
                Element elem = (Element)element;
                Console.WriteLine($"A: {elem.A} B: {elem.B} C: {elem.C}");
            }

            Console.ReadKey();
        }
    }

    class Element
    {
        private int a,b,c;

        public Element(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A => a;
        public int B => b;
        public int C => c;
    }

    class TestClass : IEnumerable, IEnumerator
    {
        Random random = new Random((int)DateTime.Now.Ticks);
        Element[] items;

        public TestClass(int amount)
        {
            items = new Element[amount];

            for (int i = 0; i < amount; i++)
            {
                items[i] = new Element(random.Next(100), random.Next(100), random.Next(100));
            }
        }

        Element current = null;
        private int position = -1;

        public object Current => current;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            position++;
            if (position<items.Length)
            {
                this.current = items[position];
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
