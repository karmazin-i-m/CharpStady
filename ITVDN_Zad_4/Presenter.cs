using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_4
{
    class Presenter
    {
        Calculate calculate;
        MainWindow window;
        public Presenter(MainWindow window)
        {
            this.window = window;
            calculate = new Calculate();
            window.BackSpaceClick += () => window.TextBox.Text = calculate.BackSpace(window.TextBox.Text);
            window.ClearClick += () => window.TextBox.Text = calculate.Clear();
            window.ClearEntyClick += () => window.TextBox.Text = calculate.ClearEntry();
            window.SubtractionClick += () => calculate.Subtraction(window.TextBox.Text);
            window.SubtractionClick += () => window.TextBox.Text = calculate.ClearEntry();
            window.PluseClick += () => calculate.Summ(window.TextBox.Text);
            window.PluseClick += () => window.TextBox.Text = calculate.ClearEntry();
            window.DivisionClick += () => calculate.Division(window.TextBox.Text);
            window.DivisionClick += () => window.TextBox.Text = calculate.ClearEntry();
            window.MultiplyClick += () => calculate.Multiplay(window.TextBox.Text);
            window.MultiplyClick += () => window.TextBox.Text = calculate.ClearEntry();
            window.Resqwerty += () => window.TextBox.Text = calculate.Result(window.TextBox.Text).ToString();
        }
    }
}
