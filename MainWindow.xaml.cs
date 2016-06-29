// VBConversions Note: VB project level imports
using System.Windows.Input;
using System.Windows.Data;
using System.Windows.Documents;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Windows.Navigation;
using System.Windows.Media.Imaging;
using System.Windows;
using Microsoft.VisualBasic;
using System.Windows.Media;
using System.Collections;
using System;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Linq;
using System.Diagnostics;
// End of VB project level imports


namespace BlackCrystal
{
	public partial class MainWindow
	{
		
		private void MainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			
		}
		
		public MainWindow()
		{
			
			// This call is required by the designer.
			InitializeComponent();
			
			// Add any initialization after the InitializeComponent() call.
			System.Data.DataSet x = new System.Data.DataSet();
			x.Tables.Add("tabla1");
			x.Tables[0].Columns.Add("Columna1");
			x.Tables[0].Columns.Add("Columna2");
			x.Tables[0].Columns.Add("Columna3");
			x.Tables[0].Columns.Add("Columna4");
			
			for (int i = 0; i <= 20; i++)
			{
				x.Tables[0].Rows.Add(new string[] {i.ToString(), "prueba", i.ToString(), "prueba"});
			}
			x.AcceptChanges();
			this.DataContext = x;
		}
	}
	
}
