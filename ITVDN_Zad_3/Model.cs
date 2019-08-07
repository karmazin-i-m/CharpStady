using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ITVDN_Zad_3
{
    class Model
    {
        Stopwatch timer = new Stopwatch();


        public void TimerEnable()
        {
            timer.Start();
        }
        public void TimerDisable()
        {
            timer.Stop();
        }
        public void TimerReset()
        {
            timer.Restart();
        }
        public long GetMilliseconds()
        {
            return timer.ElapsedMilliseconds;
        }
    }
}
