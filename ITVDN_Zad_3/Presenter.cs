using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_3
{
    class Presenter
    {
        Model model = null;
        View view = null;

        public Presenter(View view)
        {
            model = new Model();
            this.view = view;

            view.StartClik += Start;
            view.StopClik += Stop;
            view.ResetClik += Reset;
        }

        private void Start()
        {
            model.TimerEnable();
            while (true)
            {
                view.ShowTime(GetTime());
            }
        }

        private void Stop()
        {
            model.TimerDisable();
        }

        private void Reset()
        {
            model.TimerReset();
        }

        public long GetTime()
        {
            return model.GetMilliseconds();
        }
    }
}
