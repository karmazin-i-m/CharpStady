using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITVDN_Zad_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event Action PluseClick;
        public event Action SubtractionClick;
        public event Action MultiplyClick;
        public event Action DivisionClick;
        public event Action ClearEntyClick;
        public event Action ClearClick;
        public event Action BackSpaceClick;
        public event Action Resqwerty;


        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void Pluse_Click(object sender, RoutedEventArgs e)
        {
                PluseClick?.Invoke();
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
                SubtractionClick?.Invoke();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {

            MultiplyClick?.Invoke();
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            DivisionClick?.Invoke();
        }

        private void ClearEnty_Click(object sender, RoutedEventArgs e)
        {
            ClearEntyClick?.Invoke();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearClick?.Invoke();
        }

        private void BackSpace_Click(object sender, RoutedEventArgs e)
        {
            BackSpaceClick?.Invoke();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "9";
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Resqwerty?.Invoke();
        }
    }
}
