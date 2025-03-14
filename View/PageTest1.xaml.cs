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

namespace TestWork.View
{
    /// <summary>
    /// Логика взаимодействия для PageTest1.xaml
    /// </summary>
    public partial class PageTest1 : Page
    {

        int b = 0;
        int c = 0;
        public PageTest1()
        {
            InitializeComponent();
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (RB2.IsChecked == true)
            {
                MessageBox.Show("правильно");
                b = b + 1;
            }
            else MessageBox.Show("неправильно");
            p2.Visibility = Visibility.Collapsed;
            products.SelectedItem = v3;
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (ChB1.IsChecked == false && ChB2.IsChecked == false && ChB3.IsChecked == false && ChB4.IsChecked == false && ChB5.IsChecked == false)
            {
                MessageBox.Show("правильно");
                b = b + 1;
            }
            else MessageBox.Show("неправильно");
            p3.Visibility = Visibility.Collapsed;
            products.SelectedItem = v4;
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "5")
            {
                MessageBox.Show("правильно");
                b = b + 1;
            }
            else MessageBox.Show("неправильно");
            p1.Visibility = Visibility.Collapsed;
            products.SelectedItem = v2;
        }


        private void p4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {

        }



        private void p6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p8_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void p8_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void p9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p9_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void p9_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void p9_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void p10_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
