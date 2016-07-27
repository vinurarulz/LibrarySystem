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
    /// Interaction logic for UserRegistrations.xaml
    /// </summary>
    public partial class UserRegistrations : Window
    {
        public UserRegistrations()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            combo_status.Items.Add("Active");
            combo_status.Items.Add("Deactive");

            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    var maxValue = db.Users.Max(x => x.User_ID);
                    txt_user_id.Text = (maxValue + 1).ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("UserName has been wrong !", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    Employee emp = db.Employees.SingleOrDefault(x => x.Emp_ID == 2);
                    Status st = db.Status.SingleOrDefault(x => x.Status_ID == 1);
                    User_Type utype = db.User_Types.SingleOrDefault(x => x.User_Type_ID == 1);

                    string[] s = txt_emp_name.Text.Split(' ');

                    User us = new User();
                    us.FName = s[0];
                    us.LName = s[1];
                    us.Tel_Hand = txt_telhand.Text;
                    us.Tel_Land = txt_telland.Text;
                    //us.DOB = datepicker_DOB.Text;

                    // db.Loginzs.InsertOnSubmit(lg);
                    db.SubmitChanges();

                    MessageBox.Show("Data Inserted Successfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
