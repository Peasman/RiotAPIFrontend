using System;
namespace ChampionModel
{
    public class Champion
    {
        public long id { get; set; }
        public String key { get; set; }
        public String name { get; set; }
        public String title { get; set; }
        // Skin[] skins { get; set; }
        public String lore { get; set; }
        public ChampionStats stats { get; set; }
        //ChampionImage image { get; set; }
        public String version { get; set; }
    }
}