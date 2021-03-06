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
using System.Windows.Shapes;

namespace RiotAPIFrontEnd
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        Window mainWindow;
        public StartPage(Window pWindow)
        {
           
            mainWindow = pWindow;
            InitializeComponent();
            regions.Items.Add("EUW");
            regions.Items.Add("NA");
            regions.Items.Add("KR");
            regions.Items.Add("EUNE");
            regions.Items.Add("TR");
            regions.SelectedItem = regions.Items.GetItemAt(0);
        }
        public void clearContent(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= clearContent;
        }
        private void findSummoner(object sender, RoutedEventArgs e)
        {
            String name = summonerName.Text;
            String region = regions.SelectedItem as String;
            mainWindow.Content = new MainPage(mainWindow, name, region);
        }
    }
}
