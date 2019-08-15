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

namespace ClassWork_Zad_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Exception e = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ValidLogin(LoginBox.Text);
                ValidPassword(PasswordBox.Text);
            }
            catch (NotValidLoginException exception)
            {
                this.e = exception;
                MessageBox.Show(exception.Message, "Ошибка логина!");
                LoginBox.Text = null;
            }
            catch (NotValidPassException exception)
            {
                this.e = exception;
                MessageBox.Show(exception.Message, "Ошибка пароля!");
                PasswordBox.Text = null;
            }
            catch (ArgumentNullException exception)
            {
                this.e = exception;
                MessageBox.Show(exception.Message, "Ошибка!");
            }

            if (this.e == null)
            {
                MessageBox.Show("Вы Успешно Авторизовались!", "Suxcesful");
            }

            this.e = null;
        }

        private void LoginBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ValidLogin(string login)
        {
            if (login == null) throw new ArgumentNullException("Вы ввели пустое поле!");

            login.ToLower();
            char[] loginChar = login.ToCharArray();

            for (int i = 0; i < loginChar.Length; i++)
            {
                int element = loginChar[i];
                if (element < 48 | element > 57  & element < 97 | element > 122)
                {
                    throw new NotValidLoginException($"Вы ввели недопустимый символ {(char)element}");
                }
            }
        }

        private void ValidPassword(string password)
        {
            if (password == null) throw new ArgumentException("Вы ввели пустое поле!");

            password.ToLower();
            char[] loginChar = password.ToCharArray();

            for (int i = 0; i < loginChar.Length; i++)
            {
                int element = loginChar[i];
                if (element < 48 | element > 57 & element < 97 | element > 122 && element < 35 | element > 38 & element < 40 | element > 42 && element != '!' && element != '@' && element != '^')
                {
                    throw new NotValidPassException($"Вы ввели недопустимый символ {(char)element} (1)");
                }

                //else if (element == '!' | element == '@' | element == '^')
                //    break;
            }
        }


        class NotValidLoginException : Exception
        {
            private string message = null;
            private Exception innerException = null;
            public NotValidLoginException()
                : base()
            {

            }
            public NotValidLoginException(string message)
                : base(message)
            {
                this.message = message;
            }
            public NotValidLoginException(string message, Exception innerException)
                : base(message, innerException)
            {
                this.message = message;
                this.innerException = innerException;
            }

            public Exception InnerException => innerException;

            public override string Message => message;

        }
        class NotValidPassException : Exception
        {
            private string message = null;
            private Exception innerException = null;
            public NotValidPassException()
                : base()
            {

            }
            public NotValidPassException(string message)
                : base(message)
            {
                this.message = message;
            }
            public NotValidPassException(string message, Exception innerException)
                : base(message, innerException)
            {
                this.message = message;
                this.innerException = innerException;
            }

            public Exception InnerException => innerException;

            public override string Message => message;
        }


    }


}
