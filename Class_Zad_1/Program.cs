using System;
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
            char key;
            Intro();
            RailStation railStation = RailStation.Instance();
            while (true)
            {
                key = Console.ReadKey(false).KeyChar;

                switch (key)
                {
                    case '1':
                        railStation.AddTrain();
                        break;
                    case '2':
                        railStation.ShowTrainInformations();
                        break;
                    case '3':
                        railStation.ShowInformationOfTrain();
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Вы ввели что-то не верно");
                        break;
                }
            }
        }
        static void Intro()
        {
            Console.WriteLine("Для управления следуйте дальнейшим инструкциям: ");
            Console.WriteLine("q - Выход");
            Console.WriteLine("1 - Добавить поезд");
            Console.WriteLine("2 - Вывести информацию о всех поездах.");
            Console.WriteLine("3 - Вывести информацию о конкретном поезде.");
        }
    }
}
