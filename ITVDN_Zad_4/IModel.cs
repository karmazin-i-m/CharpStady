using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_4
{
    interface IModel
    {
        string ClearEntry();
        string Clear();
        void Summ(string str);
        void Multiplay(string str);
        void Subtraction(string str);
        void Division(string str);
        string BackSpace(string str);
        double Result(string str);
    }
}
