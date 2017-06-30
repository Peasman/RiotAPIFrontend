using System;
namespace Models.LowDetailMatch
{
    public class LowDetailMatch
    {
        public String platformId { get; set; }
        public long gameId { get; set; }
        public int champion { get; set; }
        public int queue { get; set; }
        public int season { get; set; }
        public long timestamp { get; set; }
        public String role { get; set; }
        public String lane { get; set; }
        public String getContent()
        {
            return gameId + ",\"" + platformId + "\"," + champion + "," + queue + "," + season + "," + timestamp + ","
                    + "\"" + role + "\",\"" + lane + "\"";
        }
    }

}
