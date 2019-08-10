using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace ITVDN_Zad_3
{
    class Presenter
    {
        Model model = null;
        View view = null;
        DispatcherTimer Timer;

        public Presenter(View view)
        {
            Timer = new DispatcherTimer();
            model = new Model();
            this.view = view;

            Timer.Interval = new TimeSpan(100);
            view.StartClik += Start;
            view.StopClik += Stop;
            view.ResetClik += Reset;
            Timer.Tick += SetTime;
            
        }

        private void Start()
        {
            model.TimerEnable();
            Timer.Start();
        }

        private void Stop()
        {
            model.TimerDisable();
            Timer.Stop();
        }

        private void Reset()
        {
            model.TimerReset();
            view.Label.Content = "";
            Timer.Stop();
        }

        public void SetTime(object sender, System.EventArgs e)
        {
            view.Label.Content = $"{model.GetHours()}:{model.GetMinutes()}:{model.GetSeconds()}";
        }
    }
}
