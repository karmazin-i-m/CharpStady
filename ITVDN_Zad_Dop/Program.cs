using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_Dop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свою дату рождения: ");
            DateTime bithday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;

            if (now.DayOfYear <= bithday.DayOfYear)
            {
                Console.WriteLine($"До вашего дня рождения еще {bithday.DayOfYear - now.DayOfYear}");
            }
            else
                Console.WriteLine($"До вашего дня рождения еще {bithday.DayOfYear + 365 - now.DayOfYear} дня");

            Console.ReadKey();
        }
    }
}
