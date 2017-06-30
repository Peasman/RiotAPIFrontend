using System;
using System.Collections.Generic;
namespace MatchModels
{
    public class MatchDetail
    {
        public long gameCreation { get; set; }
        public long gameDuration { get; set; }
        public long gameId { get; set; }
        public String gameMode { get; set; }
        public String gameType { get; set; }
        public String gameVersion { get; set; }
        public int mapId { get; set; }
        public List<ParticipantIdentity> participantIdentities { get; set; }
        public List<Participant> participants { get; set; }
        public String platformId { get; set; }
        public int queueId { get; set; }
        public int seasonId { get; set; }
        public String region { get; set; }
        public List<Team> teams { get; set; }
    public void test()
        {
            Stats s = new Stats();
        }
    }
}