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

        }

        int empid;
        string nic;
        string fname;
        string lname;
        string tell;
        string email;
        string add1;
        string add2;
        string add3;

        int logid;
        string uname;
        string pwd;
        int status_id;
        string status_discrip;

        private void btn_update1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            empid = Convert.ToInt16(txt_emp_id);
            nic = txt_nic.Text;
            fname = txt_fname.Text;
            lname = txt_lname.Text;
            tell = txt_contac.Text;
            email = txt_email.Text;
            add1 = txt_add1.Text;
            add2 = txt_add2.Text;
            add3 = txt_add3.Text;

            uname = txt_uname.Text;
            pwd = txt_pwd.Text;
            status_discrip = combo_status.SelectedItem.ToString();
            

            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    //  Employee emp = db.Employees.SingleOrDefault(x => x.Emp_ID == empid);
                    Employee emp = db.Employees.SingleOrDefault();
                    Status st = db.Status.SingleOrDefault(x => x.Status1 == status_discrip);
                   
                    emp.Emp_NIC = nic;
                    emp.FName = fname;
                    emp.LName = lname;
                    emp.Tel = tell;
                    emp.Email = email;
                    emp.Add1 = add1;
                    emp.Add2 = add2;
                    emp.Add3 = add3;
                    Loginz log = new Loginz();
                    log.UserName = uname;
                    log.Pwd = pwd;
                    log.Emp_ID = emp.Emp_ID;
                    log.Status_ID = st.Status_ID;
                    db.Employees.InsertOnSubmit(emp);
                    db.Loginzs.InsertOnSubmit(log);
                    db.SubmitChanges();
                }

            }
            catch(Exception ex)
            {

            }

        }
    }
}
