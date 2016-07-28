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
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    using (DB_ClassDataContext db = new DB_ClassDataContext())
            //    {
            //        Employee emp = db.Employees.SingleOrDefault(x => x.Emp_ID == 2);

            //        Status st = db.Status.SingleOrDefault(x => x.Status_ID == 1);

            //        Loginz lg = new Loginz();
            //        lg.UserName = "gfy";
            //        lg.Pwd = "123";
            //        lg.Emp_ID = emp.Emp_ID;
            //        lg.Status_ID = st.Status_ID;
            //        db.Loginzs.InsertOnSubmit(lg);
            //        db.SubmitChanges();

            //        MessageBox.Show("Data Inserted Successfully");

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex);
            //}

            //try { 
            //using (DB_ClassDataContext db = new DB_ClassDataContext())
            //{
            //    Employee em =new Employee();
            //  //  User_Type utype = db.User_Types.SingleOrDefault(x => x.User_Type_ID == 2);

            //    Employee emp = new Employee();
            //    emp.Emp_NIC = txt_nic.Text;
            //    emp.FName = txt_fname.Text;
            //    emp.LName = txt_lname.Text;
            //    emp.Tel = txt_contac.Text;
            //    emp.Email = txt_email.Text;
            //    emp.Add1 = txt_add1.Text;
            //    emp.Add2 = txt_add2.Text;
            //    emp.Add3 = txt_add3.Text;
            //    db.Employees.InsertOnSubmit(em);
            //    db.SubmitChanges();
            //}

            //}catch(Exception ex)
            //{

            //}

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    Employee emp = db.Employees.SingleOrDefault(x => x.Emp_ID == 3);
                    Status st = db.Status.SingleOrDefault(x => x.Status_ID == 1);
                    Loginz lg = db.Loginzs.SingleOrDefault(x => x.Login_ID == 32);

                    // Loginz lg = new Loginz();
                    lg.UserName = "efj";
                    lg.Pwd = "123";
                    lg.Emp_ID = emp.Emp_ID;
                    lg.Status_ID = st.Status_ID;
                    //db.Loginzs.InsertOnSubmit(lg);
                    db.SubmitChanges();

                    MessageBox.Show("Data Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {

                    Loginz lg = db.Loginzs.SingleOrDefault(x => x.Login_ID == 32);
                    db.Loginzs.DeleteOnSubmit(lg);
                    db.SubmitChanges();

                    MessageBox.Show("Data Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    Loginz lg = db.Loginzs.SingleOrDefault(x => x.Login_ID == 32);
                    string username = lg.UserName;
                    string pass = lg.Pwd;
                    string empname = lg.Employee.FName + " " + lg.Employee.LName;

                    MessageBox.Show("Login Name : " + username + "\nPassword : " + pass + "\nEmp Name : " + empname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    Author lg = new Author();
                    lg.Author1 = "S.G.P.Dias";
                    db.Authors.InsertOnSubmit(lg);
                    db.SubmitChanges();

                    MessageBox.Show("Data Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //try
            //{
            //    using (DB_ClassDataContext db = new DB_ClassDataContext())
            //    {
            //        SubCategory lg =new SubCategory();
            //        lg.SubCategory1 = "my2";
            //        db.SubCategories.InsertOnSubmit(lg);
            //        db.SubmitChanges();

            //        MessageBox.Show(" Successfully");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex);
            //}



            //try
            //{
            //    using (DB_ClassDataContext db = new DB_ClassDataContext())
            //    {
            //        Loginz lg = db.Loginzs.SingleOrDefault(x => x.Login_ID == 1);

            //        if (lg == null)
            //        {
            //            MessageBox.Show("data are not hear");
            //        }
            //        else
            //        {
            //            MessageBox.Show(lg.UserName);
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex);
            //}

            //try
            //{
            //    using (DB_ClassDataContext db = new DB_ClassDataContext())
            //    {
            //        SubCategory lg = new SubCategory();
            //        lg.SubCategory1 = "History of Srilanka";
            //        lg.MainCategory_ID = 2;
            //        db.SubCategories.InsertOnSubmit(lg);
            //        db.SubmitChanges();

            //        MessageBox.Show(" Successfully");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex);
            //}
        }
    }
}
