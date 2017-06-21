using System;
namespace ChampionModel
{
    public class ChampionStats
    {
        public static double asBase = 0.625;
        // Health Points
        double hp { get; set; }
        double hpperlevel { get; set; }

        // Mana
        double mp { get; set; }
        double mpperlevel { get; set; }
        // movementSpeed
        double movespeed { get; set; }
        // Armor
        double armor { get; set; }
        double armorperlevel { get; set; }

        // Magic Resistence
        double spellblock { get; set; }
        double spellblockperlevel { get; set; }
        // Attackrange
        double attackrange { get; set; }
        // HealthPoint-Regeneration
        double hpregen { get; set; }
        double hpregenperlevel { get; set; }
        // ManaReg
        double mpregen { get; set; }
        double mpregenperlevel { get; set; }
        // Crit-Chance
        double crit { get; set; }
        double critperlevel { get; set; }

        // Attack Damage
        double attackdamage { get; set; }
        double attackdamageperlevel { get; set; }
        // attackspeed
        double attackspeedoffset { get; set; }
        double attackspeedperlevel { get; set; }

        public ChampionStats()
        {
            // System.out.println(spellblock);
        }

        public String toString()
        {
            return "HP: " + hp + "\nHP pro level: " + hpperlevel + "\nHP-Regeneration: " + hpregenperlevel;
        }
        public String getContent()
        {
            return hp + "," + hpperlevel + "," + mp + "," + mpperlevel + "," + movespeed + "," + armor + "," + armorperlevel + "," + spellblock + "," + spellblockperlevel + "," + attackrange + "," + hpregen + "," + hpregenperlevel + "," + mpregen + "," + mpregenperlevel + "," + attackdamage + "," + attackdamageperlevel + "," + attackspeedoffset + "," + attackspeedperlevel;
        }

    }


}