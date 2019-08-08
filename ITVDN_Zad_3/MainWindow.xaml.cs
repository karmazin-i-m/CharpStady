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


namespace ITVDN_Zad_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class View : Window
    {
        Presenter presenter = null;
        
        public View()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        public event Action StartClik = null;
        public event Action StopClik = null;
        public event Action ResetClik = null;

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (StartClik != null)
            {
                StartClik.Invoke();
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (StartClik != null)
            {
                StopClik.Invoke();
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            if(ResetClik != null)
            {
                ResetClik.Invoke();
            }
        }
    }
}
