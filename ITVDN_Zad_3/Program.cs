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
            Price[] prices = new Price[3];

            for (int i = 0; i < prices.Length; i++)
            {
                Console.Write("Введите название товара: ");
                string prod = Console.ReadLine();
                Console.Write("Введите название магазина: ");
                string marcet = Console.ReadLine();
                Console.Write("Введите стоимость: ");
                int cost = Int32.Parse(Console.ReadLine());

                prices[i] = new Price(prod, marcet, cost);
            }
            
            Array.Sort(prices, new Comparison<Worker>((a,b) => a.Name.CompareTo(b.Name)));

            Console.Write("Введите название магазина для проверки товара: ");
            string marketName = Console.ReadLine();
            bool flag = false;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i].Market != marketName) continue;

                flag = true;
                Console.WriteLine(prices[i]);
            }

            if (!flag) throw new Exception("Ошибка!!!");

            Console.ReadKey();
        }
    }
    struct Price
    {
        string productName;
        string marketName;
        int cost;

        public Price(string productName, string marketname, int cost)
        {
            this.productName = productName;
            this.marketName = marketname;
            this.cost = cost;
        }

        public string Product => productName;
        public string Market => marketName;
        public int Cost => cost;

        public override string ToString()
        {
            return $"Product Name: {this.productName}, marcketName: {this.marketName}, Cost: {this.cost}";
        }
    }
}
