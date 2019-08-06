using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_2
{
    class Car
    {
        string name;
        int yearIssue;

        public Car(string name, int yearIssue)
        {
            this.name = name;
            this.yearIssue = yearIssue;
        }

        public int Year { get => yearIssue; }
        public string Name { get => name; }
    }
}
