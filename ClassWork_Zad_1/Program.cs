using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите свою профессию: ");
                string prof = Console.ReadLine();
                Profession profession;

                switch (prof)
                {
                    case "Программист":
                        profession = Profession.Programmer;
                        break;
                    case "Шахтер":
                        profession = Profession.Miner;
                        break;
                    case "Повар":
                        profession = Profession.Cook;
                        break;
                    case "Бухгалтер":
                        profession = Profession.Accountant;
                        break;
                    case "Босс":
                        profession = Profession.Boss;
                        break;
                    case "q":
                        Console.WriteLine("Выхожу из программы...");
                        Thread.Sleep(2000);
                        return;
                    default:
                        profession = Profession.Default;
                        break;
                }

                if (profession != Profession.Default)
                {
                    Console.WriteLine("Ваша профессия есть в списке!");
                }
                else Console.WriteLine("Такой профессии нет в списке!");
            }
            

            Console.ReadKey();
        }
    }
    enum Profession : int
    {
        Default = 0,
        Programmer,
        Cook,
        Miner,
        Accountant,
        Boss,
    }
}