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
using System.Windows.Shapes;

namespace eldrdrwpf
{
    /// <summary>
    /// Логика взаимодействия для Tarif.xaml
    /// </summary>
    public partial class Tarif : Window
    {
        public Tarif()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.Top = this.Top;
            mainWindow.Left = this.Left;
            this.Close();
        }
    }
}
