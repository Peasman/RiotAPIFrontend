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
using System.Threading;
using Core;
using Models.Summoner;
namespace RiotAPIFrontEnd
{
    /// <summary>
    /// Interaktionslogik für MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Main m;
        Window mainWindow;
        public MainPage(Window pWindow)
        {
            mainWindow = pWindow;
            InitializeComponent();
            //m = new Main(this);
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            m.sendMessage("getSummoner peasman euw");
            String receive;
            Thread t = new Thread(m.receiveSummoner);
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new ChampionPage(mainWindow);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new StartPage(mainWindow);
        }

        private void matchHistory_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new MatchHistory(mainWindow);
        }
    }

}
