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
            Worker[] workers = new Worker[5]
            {
                new Worker("John1", Profession.Boss, 1980),
                new Worker("BJohn2", Profession.Coock, 2007),
                new Worker("CJohn3", Profession.Programer, 2000),
                new Worker("AJohn4", Profession.Programer, 2020),
                new Worker("DJohn5", Profession.Waiter, 2019),
            };

            Array.Sort(workers, new Comparison<Worker>((a,b) => a.Name.CompareTo(b.Name)));

            Console.Write("Введите порог рабочего опыта: ");
            int exp = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Year < 1980 || workers[i].Year > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Время работы вне диапазона.");
                }
                if (DateTime.Now.Year - workers[i].Year > exp)
                {
                    Console.WriteLine(workers[i]);
                }
            }

            Console.ReadKey();
        }
    }

    struct Worker
    {
        string name;
        Profession profession;
        int year;

        public Worker(string name, Profession profession, int year)
        {
            this.name = name;
            this.profession = profession;
            this.year = year;
        }

        public int Year => year;
        public string Name => name;

        public override string ToString()
        {
            return $"Name: {this.name}, Profession: {this.profession}, Work experience: {DateTime.Now.Year - this.year}";
        }
    }

    enum Profession
    {
        Default,
        Boss,
        Programer,
        Coock,
        Waiter
    }
}
