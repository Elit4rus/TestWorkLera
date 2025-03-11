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
using System.Windows.Shapes;

namespace TestWork.View
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationTeacherWindow.xaml
    /// </summary>
    public partial class AuthorizationTeacherWindow : Window
    {
        public AuthorizationTeacherWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginPb.Password))
            {
                MessageBox.Show("Введите пароль");

            }
            else
            {
                if (LoginPb.Password == "123")
                {
                    DialogResult = true;
                    MessageBox.Show("Данные верны");
                    Close();
                }
                else
                {
                    MessageBox.Show("Данные неверны");
                }
            }
        }
    }
}
