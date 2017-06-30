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
using Core;
using RiotAPIFrontEnd.Models.Champions;
namespace RiotAPIFrontEnd
{
    /// <summary>
    /// Interaktionslogik für ChampionList.xaml
    /// </summary>
    public partial class ChampionPage : Page
    {
        Boolean first = true;
        List<ChampionPanel> rest;
        List<ChampionPanel> shown;
        TextBox T;
        TextBox k;
        Window mainWindow;
        public ChampionPage(Window pWindow)
        {
            mainWindow = pWindow;
            InitializeComponent();
            rest = new List<ChampionPanel>();
            shown = new List<ChampionPanel>();
            flow = new WrapPanel();
            flow.Background = new SolidColorBrush(Colors.Black);
            //ChampionContainer cc1 = new ChampionContainer() { , name = new Label() { Content = "Ashe" } };
            foreach (KeyValuePair<int,String> lc in StandardList.Instance.coreList)
            {
                ChampionPanel sp = new ChampionPanel(lc.Key,lc.Value);
                shown.Add(sp);
                flow.Children.Add(sp);
            }
            //mainPanel.Background = new SolidColorBrush(Colors.Black);
            scroll.Content = flow;
        }
        private void updateList(String input)
        {
            String n = input.ToLower();
            foreach (ChampionPanel cp in flow.Children)
            {
                if (!cp.name.ToLower().Contains(n))
                {
                    cp.Visibility = Visibility.Collapsed;
                }
                else
                {
                    cp.Visibility = Visibility.Visible;
                }
            }
        }
        public void clearContent(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= clearContent;
        }
        private class ChampionPanel : StackPanel, IComparable<ChampionPanel>
        {
            public String name { get; set; }
            int id;
            //Container bestehend aus Label + Button
            public ChampionPanel(int id, String name)
            {
                this.name = name;
                this.id = id;
                Button btn = new Button();
                btn.Width = 100;
                btn.Height=100;
                btn.Background = new ImageBrush(new Core.ImageDownloader().downloadImage(name, ImageDownloader.SQUARE));
                btn.Name = "btn1";
                btn.Click += btn1_Clicked;
                Label l = new Label() { Content =id + ": " + name };
                l.Background = new SolidColorBrush(Colors.Black);
                l.Foreground = new SolidColorBrush(Colors.White);
                l.HorizontalAlignment = HorizontalAlignment.Center;
                Children.Add(btn);
                Children.Add(l);
            }
            //Methode zum zeigen eines Buttons
            private void btn1_Clicked(object sender, RoutedEventArgs e)
            {
                Window w = new Window();
                w.Background = new SolidColorBrush(Colors.Black);
                w.Height = 717;
                w.Width = 1215;
                //Image i = new Image() { Source = new BitmapImage(new Uri(@"RiotAPI\" + name + "_0.jpg", UriKind.Relative)) };
                Image i = new Image() { Source = new Core.ImageDownloader().downloadImage(name, ImageDownloader.SPLASH) };
                w.Content = i;
                w.Show();
            }
            public int CompareTo(ChampionPanel obj)
            {
                return name.CompareTo(obj.name);
            }
        }

        private void windowSizeChanged(object sender, SizeChangedEventArgs e)
        {
        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (first) { first = false; return; }
            updateList(textBox.Text);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new MainPage(mainWindow);
        }
    }
}
