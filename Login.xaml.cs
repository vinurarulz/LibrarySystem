﻿using System;
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
using DAO;
using System.Data;

namespace BlackCrystal
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void chec_fpwd_Checked(object sender, RoutedEventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
            this.Hide();
        }

        

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            EmployeRegistration emp = new EmployeRegistration();
            emp.Show();
            this.Hide();
        }
    }
}
