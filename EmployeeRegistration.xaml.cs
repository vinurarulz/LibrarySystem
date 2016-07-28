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
    /// Interaction logic for EmployeRegistration.xaml
    /// </summary>
    public partial class EmployeRegistration : Window
    {
        public EmployeRegistration()
        {
            InitializeComponent();
            combo_status.Items.Add("Active");
            combo_status.Items.Add("Deactive");

            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    var maxValue = db.Employees.Max(x => x.Emp_ID);
                    txt_emp_id.Text = (maxValue + 1).ToString();
                    dataGrid1.ItemsSource = db.Employees;
                }
            }
            catch (Exception)
            {
                txt_emp_id.Text = 1 + "";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void btn_update1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                  //  Status st = db.Status.SingleOrDefault(x => x.Status1 == combo_status.SelectedItem.ToString());
                  //  User_Type utype = db.User_Types.SingleOrDefault(x => x.User_Type_ID == 2);

                    Employee emp = new Employee();
                    emp.Emp_NIC = txt_nic.Text;
                    emp.FName = txt_fname.Text;
                    emp.LName = txt_lname.Text;
                    emp.Tel = txt_contac.Text;
                    emp.Email = txt_email.Text;
                    emp.Add1 = txt_add1.Text;
                    emp.Add2 = txt_add2.Text;
                    emp.Add3 = txt_add3.Text;
                    db.Employees.InsertOnSubmit(emp);
                    db.SubmitChanges();

                    //Loginz log = new Loginz();
                    //log.UserName = txt_uname.Text; ;
                    //log.Pwd = txt_pwd.Text;
                    //log.Emp_ID = emp.Emp_ID;
                    //log.Status_ID = st.Status_ID;
                    //log.User_Type_ID = utype.User_Type_ID;
                    //db.Loginzs.InsertOnSubmit(log);
                    //db.SubmitChanges();

                    MessageBox.Show("Employee Data inserted successfully !", "Employee Registration", MessageBoxButton.OK, MessageBoxImage.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }

        }

    }
}
