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
            var dao = new EmployeeClass();

            txt_emp_id.Text = dao.add();
        }

        private void btn_save1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
