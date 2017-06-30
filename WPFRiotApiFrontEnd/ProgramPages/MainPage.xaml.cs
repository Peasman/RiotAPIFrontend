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
        public MainPage(Window pWindow, String name, String region)
        {
            mainWindow = pWindow;
            InitializeComponent();
            m = new Main(this);
            Summoner s = m.receiveSummoner(name,region);
            summonerName.Content = s.name;
            profileIcon = new Image() { Source = new BitmapImage(new ImageDownloader().downloadImage(s.profileIconId.ToString(), ImageDownloader.PROFILE_ICON).UriSource) };
            
        }
        public MainPage(Window pWindow)
        {
            mainWindow = pWindow;
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
           
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
