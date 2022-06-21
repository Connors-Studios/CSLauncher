using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AutoUpdaterDotNET;

namespace CSLauncher
{
    /// <summary>
    /// Interaction logic for SettingsWND.xaml
    /// </summary>
    public partial class SettingsWND : Window
    {
        public SettingsWND()
        {
            InitializeComponent();
        }
        private void HomePressedLMB(object sender, MouseButtonEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            Close();
        }
        private void GamesPressedLMB(object sender, MouseButtonEventArgs e)
        {
            GamesWindow GW = new GamesWindow();
            GW.Show();
            Close();
        }
        private void SettingsPressedLMB(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void CFU(object sender, RoutedEventArgs e)
        {
            AutoUpdater.Start("https://connorsstudios.net/shared-files/123/AutoUpdates.xml");
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                // Use the RestoreBounds as the current values will be 0, 0 and the size of the screen
                Properties.Settings.Default.Top = RestoreBounds.Top;
                Properties.Settings.Default.Left = RestoreBounds.Left;
                Properties.Settings.Default.Height = RestoreBounds.Height;
                Properties.Settings.Default.Width = RestoreBounds.Width;
                Properties.Settings.Default.Maximized = true;
            }
            else
            {
                Properties.Settings.Default.Top = this.Top;
                Properties.Settings.Default.Left = this.Left;
                Properties.Settings.Default.Height = this.Height;
                Properties.Settings.Default.Width = this.Width;
                Properties.Settings.Default.Maximized = false;
            }

            Properties.Settings.Default.Save();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProjectImpact PIW = new ProjectImpact();
            PIW.Show();
            Close();
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {
            this.Top = Properties.Settings.Default.Top;
            this.Left = Properties.Settings.Default.Left;
            this.Height = Properties.Settings.Default.Height;
            this.Width = Properties.Settings.Default.Width;
            if (Properties.Settings.Default.Maximized)
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            this.Top = Properties.Settings.Default.Top;
            this.Left = Properties.Settings.Default.Left;
            this.Height = Properties.Settings.Default.Height;
            this.Width = Properties.Settings.Default.Width;
            if (Properties.Settings.Default.Maximized)
            {
                WindowState = WindowState.Maximized;
            }
        }
    }
}
