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
using System.Threading;

namespace TroubleSniper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void launch_focusfinder2_Click(object sender, RoutedEventArgs e)
        {
            //FocusFinder2.Main_Program Focus_Finder2 = new Main_Program();
            //Thread ff = new Thread(new ThreadStart(Focus_Finder2.Run));
            //ff.Start(new Window());

            //new Thread(FocusFinder2.Main_Program.)
            FocusFinder.MainWindow ff = new FocusFinder.MainWindow();
            ff.Show();

        }
    }
}
