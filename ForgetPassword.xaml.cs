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
using System.Net.Mail;
using DAO.DB;

namespace BlackCrystal
{
    /// <summary>
    /// Interaction logic for ForgetPassword.xaml
    /// </summary>
    public partial class ForgetPassword : Window
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DB_ClassDataContext db = new DB_ClassDataContext())
                {
                    Loginz lg = db.Loginzs.SingleOrDefault(x => x.UserName == txt_email.Text);
                    string title = "Email Recovery";
                    string msg = "Your CURRENT PASSWORD is : " + lg.Pwd + "\nPlease Reset your CURRENT PASSWORD to a NEW PASSWORD ";
                    SendMail(lg.UserName, title, msg);
                    MessageBox.Show("Please Check your mail to get the CURRENT PASSWORD", "Forget Password", MessageBoxButton.OK, MessageBoxImage.Information);
                    ResetPassword hm = new ResetPassword(lg.UserName);
                    hm.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("UserName has been wrong !", "Forget Password", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        void SendMail(string sendEmail, string title, string messege)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("librarysytem@gmail.com", "Vinura123");

                MailMessage mm = new MailMessage(sendEmail, sendEmail, title, messege);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);

            }
            catch (Exception)
            {
                MessageBox.Show("Email can't send. Please check your internet connection !", "Forget Password", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
