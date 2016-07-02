using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Automation;

namespace FocusFinder2
{
    public class Main_Program 
    {
        static void Main(string[] args)
        {
            Automation.AddAutomationFocusChangedEventHandler(OnFocusChangedHandler);
            Console.WriteLine("Monitoring... Hit enter to end.");
            Console.ReadLine();
        }

        private static void OnFocusChangedHandler(object src, AutomationFocusChangedEventArgs args)
        {
            Console.WriteLine("Focus changed!");
            AutomationElement element = src as AutomationElement;
            if (element != null)
            {
                string name = element.Current.Name;
                string id = element.Current.AutomationId;
                int processId = element.Current.ProcessId;
                using (Process process = Process.GetProcessById(processId))
                {
                    Console.WriteLine("  Name: {0}, Id: {1}, Process: {2}", name, id, process.ProcessName);
                }
            }
        }
    }
}

