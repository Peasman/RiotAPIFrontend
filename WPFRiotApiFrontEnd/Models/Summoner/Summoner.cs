using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models.Summoner
{
    public class Summoner
    {
        public long Id { get; set; }
        public long accountId { get; set; }
        public int profileIcon { get; set; }
        public long revisionDate { get; set; }
        public String name { get; set; }
        public int summonerLevel { get; set; }

    }
}
