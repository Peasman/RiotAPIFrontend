using System;
using System.Collections.Generic;
namespace MatchModels
{


    public class Participant
    {
        private Int16 championId { get; set; }
        private String highestAchievedSeasonTier { get; set; }
        private List<Mastery> masteries = null;
        private Int16 participantId { get; set; }
        private List<Rune> runes = null;
        private Int16 spell1Id { get; set; }
        private Int16 spell2Id { get; set; }
        private Stats stats { get; set; }
        private Int16 teamId { get; set; }
        private Timeline timeline = null;

    }

}