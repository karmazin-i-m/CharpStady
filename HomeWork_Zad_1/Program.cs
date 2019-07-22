using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Zad_1
{
    class Program
    {
        delegate int Calculate(int x, int y);
        static void Main(string[] args)
        {
            Calculate add = (x, y) => x + y;
            Calculate sub = (x, y) => x - y;
            Calculate mul = (x, y) => x * y;
            Calculate dif = (x, y) =>
            {
                if (x / y != 0) return x / y;
                return 0;
            };

            while (true)
            {
                Console.Write("Введите оператор: ");
                if (!Char.TryParse(Console.ReadLine(), out char operand)) continue;
                Console.Write("Введите х: ");
                if (!Int32.TryParse(Console.ReadLine(), out int x)) continue;
                Console.Write("Введите у: ");
                if (!Int32.TryParse(Console.ReadLine(), out int y)) continue;

                switch (operand)
                {
                    case '+':
                        Console.WriteLine(add(x, y));
                        break;
                    case '-':
                        Console.WriteLine(sub(x, y));
                        break;
                    case '/':
                        Console.WriteLine(dif(x, y));
                        break;
                    case '*':
                        Console.WriteLine(mul(x, y));
                        break;
                    case 'q':
                        Console.WriteLine("Exit...");
                        System.Threading.Thread.Sleep(2000);
                        return;
                    default:
                        Console.WriteLine("Я не знаю такого оператора :(");
                        break;
                }
            }

        }
    }
}
