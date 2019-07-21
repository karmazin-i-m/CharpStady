using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please, write name of the fruit or vegetables: ");
                string plant = Console.ReadLine();

                ValueType Plant;

                switch (plant)
                {
                    case "Banana":
                        Plant = Fruits.Babana;
                        break;
                    case "Apple":
                        Plant = Fruits.Apple;
                        break;
                    case "Melow":
                        Plant = Fruits.Melon;
                        break;
                    case "Watermelon":
                        Plant = Fruits.Watermelon;
                        break;
                    case "Strawberry":
                        Plant = Fruits.Strawberry;
                        break;
                    case "Tomato":
                        Plant = Vegetables.Tomato;
                        break;
                    case "Potato":
                        Plant = Vegetables.Potato;
                        break;
                    case "Squash":
                        Plant = Vegetables.Squash;
                        break;
                    case "Pepper":
                        Plant = Vegetables.Pepper;
                        break;
                    case "Cabbage":
                        Plant = Vegetables.Cabbage;
                        break;
                    case "Q":
                        Plant = null;
                        Console.WriteLine("Выхожу из программы...");
                        Thread.Sleep(2000);
                        return;
                    default:
                        Plant = null;
                        break;
                }

                if (Plant is Fruits)
                {
                    Console.WriteLine("You use a fruit");
                }
                else if (Plant is Vegetables)
                {
                    Console.WriteLine("You use a vegetables");
                }
                else Console.WriteLine($"{nameof(Plant)} = null \n You are writing wrong. \n Please try again.");

            }
        }
    }

    enum Fruits
    {
        Default,
        Babana,
        Apple,
        Melon,
        Watermelon,
        Strawberry,
    }

    enum Vegetables
    {
        Default,
        Tomato,
        Potato,
        Squash,
        Pepper,
        Cabbage,
    }
}
