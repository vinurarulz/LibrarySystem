using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace BlackCrystal
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : MetroWindow

    {
        public Home()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            new UserRegistrations().Show();
            //  this.Hide();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            new EmployeRegistration().Show();
            // this.Hide();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            new ResetPassword("").Show();
            // this.Hide();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            BookRegistration br = new BookRegistration();
            br.Show();
        }

        private void Tile_Click_4(object sender, RoutedEventArgs e)
        {
            Test t = new Test();
            t.Show();
        }
    }
}
