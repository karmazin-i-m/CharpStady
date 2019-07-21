using System;

namespace ClassWork_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2019, 7, 20, 13, 34, 0);

            while (true)
            {
                Console.Write("Please write name of the fruit, that you eat or different operation: ");
                string fruit = Console.ReadLine();

                if ((Fruits.Apple.ToString() == fruit || Fruits.apple.ToString() == fruit) && date.DayOfWeek == DayOfWeek.Saturday && date.Hour >= 12)
                {
                    Console.WriteLine("Watch out you can die!");
                }
                else Console.WriteLine("Don't worry all is well!");
            }
        }
    }
    enum Fruits
    {
        Default,
        Babana,
        banana,
        Apple,
        apple,
        Melon,
        melon,
        Watermelon,
        watermelon,
        Strawberry,
        strawberry,
    }
}
