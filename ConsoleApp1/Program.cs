using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ITVDN_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Customer> customers = new List<Customer>();

            cars.Add(new Car("BMW", "X5", 2015, ConsoleColor.Green));
            cars.Add(new Car("BMW", "X4", 2011, ConsoleColor.White));
            cars.Add(new Car("BMW", "X3", 2013, ConsoleColor.DarkCyan));
            cars.Add(new Car("BMW", "X2", 2015, ConsoleColor.Cyan));
            cars.Add(new Car("BMW", "X1", 2016, ConsoleColor.DarkGreen));
            cars.Add(new Car("Mazda", "M5", 2012, ConsoleColor.DarkMagenta));
            cars.Add(new Car("Mazda", "M4", 2017, ConsoleColor.Yellow));
            cars.Add(new Car("Mazda", "M3", 2012, ConsoleColor.Red));
            cars.Add(new Car("Mazda", "M2", 2011, ConsoleColor.Black));
            cars.Add(new Car("Mazda", "X1", 2009, ConsoleColor.Magenta));
            cars.Add(new Car("Porshe", "Panmera", 2019, ConsoleColor.Green));

            customers.Add(new Customer(cars[3], "Vlad", 999191516));
            customers.Add(new Customer(cars[4], "Vasya", 999191516));
            customers.Add(new Customer(cars[0], "Illya", 999191516));
            customers.Add(new Customer(cars[1], "Lilia", 999191516));
            customers.Add(new Customer(cars[2], "Oleg", 999191516));

            customers[2].AddCar = cars[10];

            StringBuilder sb = new StringBuilder();

            var query = customers.Where<Customer>(t => t.PhoneNumber == 999191516).OrderBy(t => t.Name).Select(t =>
            {
                sb.Append("Name: ");
                sb.Append(t.Name);
                sb.Append(" ");
                sb.Append("Phone number: ");
                sb.Append(t.PhoneNumber);
                sb.Append("\n");


                t.Cars.Where<Car>(a => a is Car).OrderBy(a => a.Brend).Select(a =>
                {
                    sb.Append("Brand: ");
                    sb.Append(a.Brend);
                    sb.Append(" ");
                    sb.Append("Model: ");
                    sb.Append(a.Model);
                    sb.Append(" ");
                    sb.Append("Year Issue: ");
                    sb.Append(a.YearIssue);
                    sb.Append(" ");
                    sb.Append("Color: ");
                    sb.Append(a.Color);
                    sb.Append("\n");
                    return a;
                }).ToList();

                return t;
            });

            foreach (var item in query)
            {

                Console.WriteLine(sb);
                sb.Clear();
                Console.WriteLine(new string('_', 80));
            }

            Console.ReadKey();
        }
    }
}
