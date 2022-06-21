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
using System.Windows.Shapes;
using AutoUpdaterDotNET;

namespace CSLauncher.Images
{
    /// <summary>
    /// Interaction logic for Startup.xaml
    /// </summary>
    public partial class Startup : Window
    {
        public Startup()
        {
            InitializeComponent();
            //AutoUpdater.Start("url/CSLauncherUpdate.xml");
            Startup_Delay();

        }
        public async void Startup_Delay()
        {
            await Task.Delay(2500);
            MainWindow MW = new MainWindow();
            MW.Show();
            Close();
        }
    }
}
