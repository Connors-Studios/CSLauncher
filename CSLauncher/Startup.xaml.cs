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
            VerText.Text = "Ver " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Environment.SetEnvironmentVariable("WEBVIEW2_USER_DATA_FOLDER", @"C:\Temp\");
            Startup_Delay();

        }
        public async void Startup_Delay()
        {
            await Task.Delay(1500);
            MainWindow MW = new MainWindow();
            MW.Show();
            Close();
        }
    }
}
