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
using DAO.DB;

namespace BlackCrystal
{
    /// <summary>
    /// Interaction logic for ResetPassword.xaml
    /// </summary>
    public partial class ResetPassword : Window
    {

        string UserName;

        public ResetPassword(string username)
        {
            InitializeComponent();
            UserName = username;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    if (txt_NewPW1.Text == txt_NewPW2.Text)
                    {
                        Loginz lg = db.Loginzs.SingleOrDefault(x => x.UserName == UserName);
                        lg.Pwd = txt_NewPW1.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Password has been successfully reseted !", "Reset Password", MessageBoxButton.OK, MessageBoxImage.Information);
                        Home hm = new Home();
                        hm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("New Password & Confirm Password doesn't match", "Reset Password", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("UserName has been wrong !", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}
