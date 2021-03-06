﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Run00.GitWorkItems.Views
{
	/// <summary>
	/// Interaction logic for QueryDashboard.xaml
	/// </summary>
	public partial class QueryDashboard : UserControl
	{
		public event EventHandler QueryDeleteSelected;

		public QueryDashboard()
		{
			InitializeComponent();
		}

		private void DeleteEvent(object sender, EventArgs args)
		{
			var query = ((System.Windows.FrameworkElement)(sender)).DataContext;

			if (QueryDeleteSelected == null)
				return;

			QueryDeleteSelected.Invoke(query, new EventArgs());
		}
	}
}
