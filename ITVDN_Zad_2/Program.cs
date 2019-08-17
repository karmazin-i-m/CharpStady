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
            Blok a = new Blok(1, 2, 3, 4);
            Blok b = new Blok(2, 4, 6, 8);
            Blok c = a;

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());

            if (a.Equals(b))
                Console.WriteLine("A = B");
            if (a.Equals(c))
                Console.WriteLine("A = C");

            Console.ReadKey();
        }
    }

    class Blok
    {
        int a, b, c, d;

        public Blok(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + this.a.GetHashCode();
            hash = hash * 23 + this.b.GetHashCode();
            hash = hash * 23 + this.c.GetHashCode();
            hash = hash * 23 + this.d.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Blok))
                throw new InvalidCastException();
            Blok blok = (Blok)obj;
            if (blok.a != this.a || blok.b != this.b || blok.c != this.c || blok.d != this.d)
                return false;

            return true;
        }
        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c}, d = {d}";
        }
    }
}
