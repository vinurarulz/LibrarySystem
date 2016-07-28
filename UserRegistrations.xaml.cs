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
            combo_status.Items.Add("Active");
            combo_status.Items.Add("Deactive");

            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    var maxValue = db.Users.Max(x => x.User_ID);
                    txt_user_id.Text = (maxValue + 1).ToString();
                    // dataGrid1.ItemsSource = db.Users;
                }
            }
            catch (Exception)
            {
                txt_user_id.Text = 1 + "";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {

                    //Employee emp = db.Employees.SingleOrDefault(x => x.Emp_ID == 2);
                    Status st = db.Status.SingleOrDefault(x => x.Status1 == combo_status.SelectedItem.ToString());
                    User_Type utype = db.User_Types.SingleOrDefault(x => x.User_Type_ID == 3);

                    string[] user = txt_emp_name.Text.Split(' ');
                    string[] refree = txt_rf_name.Text.Split(' ');

                    Refree rf = new Refree();
                    rf.FName = refree[0];
                    rf.LName = refree[1];
                    rf.Position = txt_rf_position.Text;
                    rf.Tel = txt_rf_contac.Text;
                    rf.Add1 = txt_rf_add1.Text;
                    rf.Add2 = txt_rf_add2.Text;
                    rf.Add3 = txt_rf_add3.Text;
                    db.Refrees.InsertOnSubmit(rf);
                    db.SubmitChanges();


                    User us = new User();
                    us.FName = user[0];
                    us.LName = user[1];
                    us.Tel_Hand = txt_telhand.Text;
                    us.Tel_Land = txt_telland.Text;
                    us.DOB = datepicker_DOB.SelectedDate.Value.ToShortDateString();
                    us.Email = txt_email.Text;
                    us.Add1 = txt_add1.Text;
                    us.Add2 = txt_add2.Text;
                    us.Add3 = txt_add3.Text;
                    us.User_Type_ID = utype.User_Type_ID;
                    us.Refree_ID = rf.Refree_ID;
                    us.Status_ID = st.Status_ID;
                    db.Users.InsertOnSubmit(us);
                    db.SubmitChanges();

                    MessageBox.Show("User Data inserted successfully !", "User Registration", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
