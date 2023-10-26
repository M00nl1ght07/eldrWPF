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

namespace eldrdrwpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.Top = this.Top;
            window1.Left = this.Left;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tarif tarif = new Tarif();
            tarif.Show();
            tarif.Top = this.Top;
            tarif.Left = this.Left;
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DeleteCar deleteCar = new DeleteCar();
            deleteCar.Show();
            deleteCar.Top = this.Top;
            deleteCar.Left = this.Left;
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddProcedure addProcedure = new AddProcedure();
            addProcedure.Show();
            addProcedure.Top = this.Top;
            addProcedure.Left = this.Left;
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Pokazat pokazat = new Pokazat();
            pokazat.Show();
            pokazat.Left = this.Left;
            pokazat.Top = this.Top;
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DeleteProcedure deleteProcedure = new DeleteProcedure();
            deleteProcedure.Show();
            deleteProcedure.Top = this.Top;
            deleteProcedure.Left = this.Left;
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            
        }
    }
}
