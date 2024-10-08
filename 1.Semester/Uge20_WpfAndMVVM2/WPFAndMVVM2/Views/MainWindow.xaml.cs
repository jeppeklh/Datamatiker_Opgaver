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
using WPFAndMVVM2.Models;
using WPFAndMVVM2.ViewModels;

namespace WPFAndMVVM2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel mvm = new();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void btnNewPerson_Click(object sender, RoutedEventArgs e)
        {
            mvm.AddDefaultPerson();
            ListBox1.ScrollIntoView(mvm.SelectedPerson);
        }

        //private void btnDeletePerson_Click(object sender, RoutedEventArgs e)
        //{
        //    //mvm.PersonsVM.Remove(mvm.SelectedPerson);
        //    mvm.DeleteSelectedPerson();
        //}
    }
}
