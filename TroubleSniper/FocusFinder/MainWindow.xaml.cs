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
        public MainWindow()
        {
            InitializeComponent();
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
            WriteOut("Focus changed!\r\n");
            AutomationElement element = src as AutomationElement;
            if (element != null)
            {
                string name = element.Current.Name;
                string id = element.Current.AutomationId;
                int processId = element.Current.ProcessId;
                using (Process process = Process.GetProcessById(processId))
                {
                    WriteOut( "            Process: " + process.ProcessName + "r\n");
                }
            }
        }
    }
}
