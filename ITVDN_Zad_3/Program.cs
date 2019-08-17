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
            House house1 = new House("MyHouse", 1);
            House house2 = (House)house1.Clone();
            House house3 = house1.DeepClone();

            if(house1.Equals(house2))
                Console.WriteLine("house1 equals house2");
            if (house1.Equals(house2))
                Console.WriteLine("house1 equals house3");

            Console.WriteLine("Press key to exit...");
            Console.ReadKey();
        }
    }
    class House : ICloneable
    {
        private string name;
        private int number;

        public House(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public string Name { get; set; }
        public DateTime Date { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public House DeepClone()
        {
            House house = (House)Clone();
            house.Name = this.Name;
            house.Date = this.Date;
            return house;
        }
    }
}
