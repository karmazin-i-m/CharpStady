using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emploe> emploes = new List<Emploe>();

            emploes.Add(new Emploe("Jacob1", 27, Position.Boss, City.Kiev, 50000));
            emploes.Add(new Emploe("Jacob2", 45, Position.Manager, City.Kharkov, 50000));
            emploes.Add(new Emploe("Jacob3", 12, Position.Manager, City.Kiev, 4532));
            emploes.Add(new Emploe("Jacob4", 36, Position.Manager, City.Kharkov, 23235));
            emploes.Add(new Emploe("Jacob5", 23, Position.Manager, City.Odessa, 4567));
            emploes.Add(new Emploe("Jacob6", 22, Position.Seller, City.Kiev, 2344));
            emploes.Add(new Emploe("Jacob7", 25, Position.Seller, City.Odessa, 9854));
            emploes.Add(new Emploe("Jacob8", 17, Position.Seller, City.Kharkov, 5673));
            emploes.Add(new Emploe("Jacob9", 32, Position.Seller, City.Odessa, 54567));
            emploes.Add(new Emploe("Jacob10", 45, Position.Seller, City.Kiev, 123134));

            var age = from e in emploes
                      where e.age >= 25
                      //orderby e
                      select e;

            var age1 = emploes.Where<Emploe>(t => t.age < 25).Select(t => t).ToList();

            foreach (var item in age)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('_', 80));

            foreach (var item in age1)
            {
                Console.WriteLine(item);
            }

            var selary = emploes.Where<Emploe>(t => t.salary > 10000).Select(T => T);
            var city = emploes.Where<Emploe>(t => t.city == City.Kiev).Select(t => new { name = t.name, t.city });

            Console.WriteLine(new string('_', 80));

            foreach (var item in selary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('_', 80));

            foreach (var item in city)
            {
                Console.WriteLine($"Name: {item.name}, City: {item.city}");
            }

            Console.ReadKey();
        }
    }
    class Emploe
    {
        public string name;
        public int age;
        public Position position;
        public City city;
        public int salary;

        public Emploe(string name, int age, Position position, City city, int salary)
        {
            this.name = name;
            this.age = age;
            this.position = position;
            this.city = city;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Age: {this.age}, Position: {this.position}, City: {this.city}, Salary: {this.salary}";
        }
    }
    enum Position
    {
        Boss,
        Seller,
        Manager,
    }
    enum City
    {
        Kiev,
        Odessa,
        Kharkov,
    }
}
