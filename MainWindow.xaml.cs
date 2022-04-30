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


namespace generat_par
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int length_of_pass = 8;
        string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            length_of_pass = 8;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            length_of_pass = 9;
        }

        private void ten_Click(object sender, RoutedEventArgs e)
        {
            length_of_pass = 10;
        }

        private void eleven_Click(object sender, RoutedEventArgs e)
        {
            length_of_pass = 11;
        }

        private void twelwe_Click(object sender, RoutedEventArgs e)
        {
            length_of_pass = 12;
        }

        private void generate_pass_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            password = "";
            while(password.Length < length_of_pass)                     //генерация пароля посимвольно
            {
                char symb = (char)rand.Next(33, 125);
                
                if (char.IsLetterOrDigit(symb))
                    password += symb;
            }
            output_password.Text = password;
        }

        private void copy_pass_Click(object sender, RoutedEventArgs e)
        {
                      
            if (output_password.Text!="")            //копирование в буфер обмена
            {
                Clipboard.SetText(password);
                MessageBox.Show("Пароль скопирован");
            }

            
        }
    }
}
