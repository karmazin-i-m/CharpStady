using System;

namespace ITVDN_Zad_Dop
{
    struct Notebook
    {
        string Model;
        string Brand;
        double Cost;

        public Notebook(string model, string brand, double cost)
        {
            Model = model;
            Brand = brand;
            Cost = cost;
        }

        public override string ToString()
        {
            Console.WriteLine($" Model: {Model}\n Brand: {Brand}\n Cost: {Cost}");
            return "";
        }
    }
}
