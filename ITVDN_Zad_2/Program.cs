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
            CarCollection<Car> cars = new CarCollection<Car>();

            Console.WriteLine("Name?");
            for (int i = 0; i < 10; i++)
            {
                cars.Add(CarFactory.GetCar(i,Console.ReadLine()));
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"Car {car.Name} {car.Year} year of issue ");
            }

            Console.ReadKey();
        }
    }

    static class CarFactory
    {
        static public Car GetCar(int year, string name)
        {
            return new Car(name, year);
        }
    }
}
