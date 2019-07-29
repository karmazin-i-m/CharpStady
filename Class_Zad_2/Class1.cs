using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_2
{
    class Class1<Y> : IInt, IInt<Y>, IInt3<Y>
        where Y : new()
    {
        public Y PropertyA { get; set; }
        public Y PropertyB { get; set; }
        public Y dateTime { get; set; }

        public void SetCurentDateTime()
        {
            dateTime = new Y();
        }

        public void SetPropsData(Y a, Y b)
        {
            PropertyA = a;
            PropertyB = b;
        }

        public void ShowCurentData()
        {
            Console.WriteLine(dateTime);
        }
    }
}
