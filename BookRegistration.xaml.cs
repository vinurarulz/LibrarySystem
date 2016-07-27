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
    /// Interaction logic for BookRegistration.xaml
    /// </summary>
    public partial class BookRegistration : Window
    {
        public BookRegistration()
        {
            InitializeComponent();
            using (DB_ClassDataContext db = new DB_ClassDataContext())
            {
                var user = (from u in db.MainCategories 
                           
                            select u.MainCategory1).SingleOrDefault();
                com__main_catagory.Items.Add(user);

            }
        }

        int bid;
        string bname;
        decimal price;
        string auther;
        int aid;
        string main_category;
        int main_catogry_id;
        string sub_category;
        int sub_category_id;

        int pid;
        string publisher;
        string pub_email;
        string pub_tell;
        string pub_add1;
        string pub_add2;
        string pub_add3;

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {




            using (DB_ClassDataContext db = new DB_ClassDataContext())
            {
                try
                {
                    Book au = db.Books.SingleOrDefault(x => x.BName == txt_bookname.Text);
                    MessageBox.Show("already exits");
                }
               catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
                //bname = txt_bookname.Text;
                //price = Convert.ToDecimal(txt_bookprice.Text);
                //auther = txt_auther.Text;
                //main_category = com__main_catagory.SelectedItem.ToString();
                //sub_category = com_Sub_Category.SelectedItem.ToString();
                //publisher = txt_publisher.Text;
                //pub_email = txt_pub_email.Text;
                //pub_tell = txt_pub_contac.Text;
                //pub_add1 = txt_pub_add1.Text;
                //pub_add2 = txt_pub_add2.Text;
                //pub_add3 = txt_pub_add3.Text;

                //try
                //{
                //    using (DB_ClassDataContext db = new DB_ClassDataContext())
                //    {

                //      Book bk = db.Books.SingleOrDefault();
                //        Author au = db.Authors.SingleOrDefault(x => x.Author1 == auther);
                //        Publisher pub = db.Publishers.SingleOrDefault(x => x.Publisher1 == publisher);
                //        MainCategory mc = db.MainCategories.SingleOrDefault(x => x.MainCategory1 == main_category);
                //        if (!bk.BName.Equals(bname))
                //        {
                //            bk.BName = bname;
                //            bk.Price = price;
                //            bk.Author_ID = au.Author_ID;
                //            bk.Publisher_ID = pub.Publisher_ID;
                //            bk.MainCategory_ID = mc.MainCategory_ID;
                //        }


                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("" + ex);
                //}
            }
    }
}
