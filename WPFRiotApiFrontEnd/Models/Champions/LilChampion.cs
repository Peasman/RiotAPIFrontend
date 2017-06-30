using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPIFrontEnd.Models.Champions
{
    public class LilChampion : IComparable<LilChampion>
    {
        public String name { get; set; }
        public int id { get; set; }
        public LilChampion(int i, String n)
        {
            name = n;
            id = i;
        }

        public int CompareTo(LilChampion other)
        {
            return name.CompareTo(other.name);
        }
    }
}
