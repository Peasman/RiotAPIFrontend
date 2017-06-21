using System;

public class LowDetailMatch
{
    public static String tableString = "gameId bigint, platformId varchar(30), champion int, queue varchar(30),season int,"
            + "timestamp bigint, role varchar(30), lane varchar(30)";
    String platformId { get; set; }
    long gameId { get; set; }
    int champion { get; set; }
    int queue { get; set; }
    int season { get; set; }
    long timestamp { get; set; }
    String role { get; set; }
    String lane { get; set; }
    public String getContent()
    {
        return gameId + ",\"" + platformId + "\"," + champion + "," + queue + "," + season + "," + timestamp + ","
                + "\"" + role + "\",\"" + lane + "\"";
    }
}
