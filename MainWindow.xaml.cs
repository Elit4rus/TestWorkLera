﻿using System;
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
using TestWork.AppDate;
using TestWork.View;

namespace TestWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameHelper.FrameMenu = FrameMenuMain;
            FrameMenuMain.Navigate(new View.PageMenu());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TeacherBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void StudentBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
