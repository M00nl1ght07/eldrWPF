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

namespace eldrdrwpf
{
    /// <summary>
    /// Логика взаимодействия для Pokazat.xaml
    /// </summary>
    public partial class Pokazat : Window
    {
        public Pokazat()
        {
            InitializeComponent();
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
