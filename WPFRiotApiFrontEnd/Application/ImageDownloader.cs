using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Net;
using System.IO;

namespace Core
{
    class ImageDownloader
    {
        private const String CHAMPION_SPLASHART_URL = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/";
        private const String CHAMPION_LOADINGSCREEN_ART_URL = "http://ddragon.leagueoflegends.com/cdn/img/champion/";
        private const String CHAMPION_PORTAIT_URL = "http://ddragon.leagueoflegends.com/cdn/7.12.1/img/champion/";
        private const String PROFILE_ICON_URL = "http://ddragon.leagueoflegends.com/cdn/7.12.1/img/profileicon/";
        private const String LOCAL_SPLASH_URI = @"Images\Splashs\";
        private const String LOCAL_LOADINGSCREEN_ART_URI = @"Images\LoadingScreenArts\";
        private const String LOCAL_CHAMPION_PORTRAIT_URI = @"Images\Squares\";
        private const String LOCAL_PROFILE_ICON_URI = @"Images\ProfileIcons\";
        public const int SPLASH = 0;
        public const int LOADING_SCREEN = 1;
        public const int SQUARE = 2;
        public const int PROFILE_ICON = 3;
        //new Uri(@"RiotAPI\" + lc.name + ".png", UriKind.Relative)
        public BitmapImage downloadImage(String name, int mode)
        {
            String usedURL = "";
            String diskURL = "";
            String fileEnding = "";
            String localName = name;
            switch (mode)
            {
                case SPLASH:
                    {
                        usedURL = CHAMPION_SPLASHART_URL;
                        diskURL = LOCAL_SPLASH_URI;
                        fileEnding = "_0.jpg";
                        break;
                    }
                case LOADING_SCREEN:
                    {
                        usedURL = CHAMPION_LOADINGSCREEN_ART_URL;
                        diskURL = LOCAL_LOADINGSCREEN_ART_URI;
                        fileEnding = "_0.jpg";
                        break;
                    }
                case SQUARE:
                    {
                        usedURL = CHAMPION_PORTAIT_URL;
                        diskURL =  LOCAL_CHAMPION_PORTRAIT_URI;
                        fileEnding = ".png";
                        break;
                    }
                case PROFILE_ICON:
                    {
                        usedURL = PROFILE_ICON_URL;
                        diskURL = LOCAL_PROFILE_ICON_URI;
                        fileEnding = ".png";
                        break;
                    }
            }
            if (!Directory.Exists(diskURL))
            {
                Directory.CreateDirectory(diskURL);
            }
            
            String urlEnding = localName + fileEnding;
            usedURL += urlEnding;
            diskURL += urlEnding;
            if (!File.Exists(diskURL))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(usedURL, diskURL);
            }  
            return new BitmapImage(new Uri(diskURL, UriKind.Relative));
        }
    }
}
