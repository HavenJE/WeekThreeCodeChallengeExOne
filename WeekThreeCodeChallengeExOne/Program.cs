

using WeekThreeCodeChallengeExOne;

class TestSoccerPlayer
{
    public static void Main()
    {
        SoccerPlayer player1 = new SoccerPlayer();
        player1.PlayerName = "Jeff";
        player1.JerseyNumber = 1;
        player1.GoalsScored = 4;
        player1.Assists = 1;
        Console.WriteLine("Player name is: {0}, Jersey namuber is: {1}, he scored {2} goals, and assisted {3}", player1.PlayerName, player1.JerseyNumber, player1.GoalsScored, player1.Assists);
    }
}