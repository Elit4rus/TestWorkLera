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

namespace TestWork.View
{
    /// <summary>
    /// Логика взаимодействия для PageAddGroup.xaml
    /// </summary>
    public partial class PageAddGroup : Page
    {
        public PageAddGroup()
        {
            InitializeComponent();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.FrameMenu.Navigate(new View.PageTeacher());
        }
    }
}
