﻿//Copyright (c) 2016 Jonathan Castle
//This software is licensed under "GPL v3" license, 
//please see the file COPYING in this distribution for license information
using System;
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
using FocusFinder;
using ProcessParents;
using System.Threading;

namespace TroubleSniper
{
    /// <summary>
    /// Interaction logic TroubleSniper
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void launch_focusfinder2_Click(object sender, RoutedEventArgs e)
        {
            FocusFinder.MainWindow ff = new FocusFinder.MainWindow();
            ff.Show();
        }

        private void launch_processparents_Click(object sender, RoutedEventArgs e)
        {
            ProcessParents.MainWindow pp = new ProcessParents.MainWindow();
            pp.Show();
        }
    }
}
