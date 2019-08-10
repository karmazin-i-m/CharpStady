using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_4
{
    class Calculate : IModel
    {
        double number = 0;
        Operands operand = Operands.Default;

        public string BackSpace(string str)
        {
            return str.Substring(0, str.Length - 1);
        }

        public string Clear()
        {
            number = 0;
            operand = Operands.Default;
            return "";
        }

        public string ClearEntry()
        {
            return "";
        }

        public void Division(string str)
        {
            operand = Operands.Division;
            number = ToDouble(str);
        }

        public void Multiplay(string str)
        {
            operand = Operands.Multiplay;
            number = ToDouble(str);
        }

        public double Result(string str)
        {
            switch (operand)
            {
                case Operands.Summ:
                    number += ToDouble(str);
                    return number;
                case Operands.Subtraction:
                    number -= ToDouble(str);
                    return number;
                case Operands.Multiplay:
                    number *= ToDouble(str);
                    return number;
                case Operands.Division:
                    number /= ToDouble(str);
                    return number;         
                case Operands.Default:
                default:
                    throw new ArgumentException();
            }
        }

        public void Subtraction(string str)
        {
            operand = Operands.Subtraction;
            number = ToDouble(str);
        }

        public void Summ(string str)
        {
            operand = Operands.Summ;
            number = ToDouble(str);
        }

        private double ToDouble(string str)
        {
            if (Double.TryParse(str, out double number))
            {
                return number;
            }
            else throw new ArgumentException();
        }
    }
}
