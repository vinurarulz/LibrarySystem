using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
   public class EmployeeClass
    {
        public bool saveEmployee(int e_id, string e_nic, string e_fname, string e_lname, string e_contac, string e_email, string e_add1, string e_add2, string e_add3, string e_uname, string e_pwd, string e_status)
        {
            try
            {
                using (var db=new LibraryDBEntities())
                {
                    var employee = new Employee() { Emp_NIC = e_nic, FName = e_fname, LName = e_lname, Tel = e_contac, Email = e_email, Add1 = e_add1, Add2 = e_add2, Add3 = e_add3, } ;
                    var employee_login = new Login() { Emp_ID = e_id };
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    
                }  
            }
            catch(Exception ex)
            {
                
            }
            return true;
        }

        public string add()
        {

            string result="";
            try
            {
                using (var db = new LibraryDBEntities())
                {
                    var eployee = new Employee();
                    result = eployee.Emp_ID.ToString();
                }
            }
            catch(Exception ex)
            {

            }

            return result;
        }
    }
}
