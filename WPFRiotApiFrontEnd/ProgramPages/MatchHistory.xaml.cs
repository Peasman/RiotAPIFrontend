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
using Models.LowDetailMatch;
using Core;

namespace RiotAPIFrontEnd
{
    /// <summary>
    /// Interaktionslogik für MatchHistory.xaml
    /// </summary>
    public partial class MatchHistory : Page
    {
        Window mainWindow;
        public MatchHistory(Window m)
        {
            mainWindow = m;
            InitializeComponent();
        }
        private void fillList(List<LowDetailMatch> list)
        {
            foreach(LowDetailMatch ldm in list)
            {
                MatchPanel mp = new MatchPanel(ldm);
            }
        }
    }

}
