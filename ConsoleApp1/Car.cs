using System;
using System.Collections.Generic;

namespace ITVDN_Zad_2
{
    class Car
    {
        readonly string brend;
        readonly string model;
        readonly int yearIssue;
        readonly ConsoleColor color;

        public Car(string brend, string model, int yearIssue, ConsoleColor color)
        {
            this.brend = brend;
            this.model = model;
            this.yearIssue = yearIssue;
            this.color = color;
        }

        public string Brend => brend;
        public string Model => model;
        public int YearIssue => yearIssue;
        public ConsoleColor Color => color;

        public override bool Equals(object obj)
        {
            return obj is Car car &&
                   brend == car.brend &&
                   model == car.model &&
                   yearIssue == car.yearIssue &&
                   color == car.color;
        }

        public override int GetHashCode()
        {
            var hashCode = -1626062013;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(brend);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(model);
            hashCode = hashCode * -1521134295 + yearIssue.GetHashCode();
            hashCode = hashCode * -1521134295 + color.GetHashCode();
            return hashCode;
        }
    }
}
