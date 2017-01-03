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
using Ikc5.TypeLibrary.Logging;
using Microsoft.Practices.Unity;
using WpfApplication.ViewModels;

namespace WpfApplication
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow(IUnityContainer container)
		{
			InitializeComponent();

			//var dynamicGridViewModel = container.Resolve<IDynamicGridViewModel>();

			//dynamicGridViewModel.CellWidth = 25;
			//dynamicGridViewModel.CellHeight = 25;
			//dynamicGridViewModel.BorderColor = Colors.Blue;
			//dynamicGridViewModel.StartColor = Colors.Azure;
			//dynamicGridViewModel.FinishColor = Colors.CornflowerBlue;

			this.DataContext = container.Resolve<IDynamicGridViewModel>();
		}
	}
}
