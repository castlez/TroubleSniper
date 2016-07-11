//Copyright (c) 2016 Jonathan Castle
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
using System.Diagnostics;
using System.Management;

namespace ProcessParents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var processes = Process.GetProcesses();
            output_processes.Text = "PARENT\tCHILD\r\n";
            Each(processes, i => output_processes.Text += GetParentName(i) + "\r\n\t" + i.ProcessName.ToString() + "\r\n" );

        }

        public void Each<T>(IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
                action(item);
        }

        public static string GetParentName(Process child)
        {
            var myId = child.Id;
            var query = string.Format("SELECT ParentProcessId FROM Win32_Process WHERE ProcessId = {0}", myId);
            var search = new ManagementObjectSearcher("root\\CIMV2", query);
            var results = search.Get().GetEnumerator();
            uint parentId;
            results.MoveNext();
            try
            {
                var queryObj = results.Current;
                parentId = (uint)queryObj["ParentProcessId"];
            }
            catch (Exception e)
            {
                return "No Parent";
            }
            
            
            try
            {
                var parent = Process.GetProcessById((int)parentId);
                return parent.ProcessName;
            }
            catch(Exception e)
            {
                return "Parent not running";
            }
            
        }
    }
}
