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
            com__main_catagory.Items.Add("History");
            com_Sub_Category.Items.Add("History of Srilanka");
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    var maxValue = db.Books.Max(x => x.Book_ID);
                    txt_bookid.Text = (maxValue + 1).ToString();
                  
                }
            }
            catch (Exception)
            {
               
            }
        }

        int auther_id;
      

       

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {                    

            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {

                    Book bk = db.Books.SingleOrDefault();
                    Author au = db.Authors.SingleOrDefault(x => x.Author1 == txt_auther.Text);
                    SubCategory sub_ctgry = db.SubCategories.SingleOrDefault(x => x.SubCategory1 == com_Sub_Category.SelectedItem.ToString());
                    if (au == null)
                    {
                        au.Author1 = txt_auther.Text;
                        auther_id = au.Author_ID;
                        db.Authors.InsertOnSubmit(au);
                        db.SubmitChanges();
                    }
                    else
                    {
                        auther_id = au.Author_ID;
                    }
                   
                   

                    if (bk==null)
                    {   
                        bk.BName = txt_bookname.Text;
                        bk.Price = Convert.ToDecimal(txt_bookprice.Text);
                        bk.Author_ID =auther_id ;                       
                        bk.MainCategory_ID = sub_ctgry.MainCategory_ID;
                        db.Books.InsertOnSubmit(bk);
                        db.SubmitChanges();
                        MessageBox.Show("Data Inserted Succusfuly", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                      //  genarate barcord an save data base
                    }
                    else
                    {
                    //genarate barcord an save data base
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not Inserted" + ex);
            }
        }
    }
}
