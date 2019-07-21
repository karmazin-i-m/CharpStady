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
            Accauntant accauntant = new Accauntant();
            var array = (int[])Enum.GetValues(typeof(Workers));
            Workers worker;
            int hours = 120;
            for (int i = 0; i < Enum.GetNames(typeof(Workers)).Length; i++)
            {
                worker = (Workers)array[i];
                Console.WriteLine($"Премия для сотрудника: {worker} = {accauntant.AskForBonus(worker, hours)} ");
                hours += 10;
            }

            Console.ReadKey();
        }
    }

    class Accauntant
    {
        public bool AskForBonus(Workers worker, int hours)
        {
            if ((int)worker >= hours)
            {
                Console.WriteLine("Сотруднику положена премия");
                return true;
            }
            Console.WriteLine("Сотруднику не положена премия");
            return false;
        }
    }

    enum Workers
    {
        Boss = 120,
        Worker1 = 160,
        Worker2 = 130,
        Worker3 = 80,
        Worker4 = 200,
    }
}
