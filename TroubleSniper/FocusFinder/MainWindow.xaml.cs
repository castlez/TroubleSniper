//Copyright (c) 2016 Jonathan Castle
//This software is licensed under "GPL v3" license, 
//please see the file COPYING in this distribution for license information


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FocusFinder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Object lockThis = new System.Object();
        int line;
        public MainWindow()
        {
            InitializeComponent();
            line = 0;
            Automation.AddAutomationFocusChangedEventHandler(OnFocusChangedHandler);
        }

        private void WriteOut(string text)
        {
            lock (lockThis)
            {
                try
                {
                    this.Dispatcher.Invoke((Action)(() =>
                              {
                                  output_textbox.Text = text + output_textbox.Text;
                              }));
                }
                catch (TaskCanceledException ex)
                {
                    //consume exception, this is just the user pressing the exit button
                }
            }
        }


        private void OnFocusChangedHandler(object src, AutomationFocusChangedEventArgs args)
        {
            WriteOut("----| Focus changed!\r\n");
            
            AutomationElement element = src as AutomationElement;
            if (element != null)
            {
                int processId = element.Current.ProcessId;
                using (Process process = Process.GetProcessById(processId))
                {
                    WriteOut(line.ToString("000") + "|            Process: " + process.ProcessName + "r\n");
                    line++;
                }
            }
        }
    }
}
