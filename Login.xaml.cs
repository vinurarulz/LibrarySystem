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
using DAO;
using System.Data;

namespace BlackCrystal
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void chec_fpwd_Checked(object sender, RoutedEventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
            this.Hide();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
         /*   try
            {
                if (new LoginClass().LoginUser(txt_uname.Text, txt_pwd.Text))
                {
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password !", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
*/
            Home h = new Home();
            h.Show();
            this.Hide();

        }
    }
}
