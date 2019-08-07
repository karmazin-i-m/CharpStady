using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000);

            account.Added += ShowMassage;
            account.Withdrawn += ShowMassage;

            Console.WriteLine(account.Summ.ToString()); 

            account.Put(4500);
            Console.WriteLine(account.Summ.ToString());

            account.Withdraw(2300);
            Console.WriteLine(account.Summ.ToString());

            Console.ReadKey();
        }

        static void ShowMassage(string str)
        {
            Console.WriteLine(str);
        }
    }
}
