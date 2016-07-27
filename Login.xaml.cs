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
using System.Data;
using DAO.DB;

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
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    Loginz lg = db.Loginzs.FirstOrDefault(x => x.UserName == txt_uname.Text && x.Pwd == txt_pwd.Text);

                    if (!lg.Equals(null))
                    {
                        Home hm = new Home();
                        hm.Show();
                        this.Hide();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("UserName or Password has been wrong !", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
