namespace FutbolManager.Models
{
    public class MatchModel
    {
        public TeamModel HomeTeam { get; private set; }
        public TeamModel AwayTeam { get; private set; }
        public int HomeScore { get; private set; }
        public int AwayScore { get; private set; }
        public bool IsFinished { get; private set; }

        public MatchModel(TeamModel homeTeam, TeamModel awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeScore = 0;
            AwayScore = 0;
            IsFinished = false;
        }

        public void SetScore(int homeScore, int awayScore)
        {
            HomeScore = homeScore;
            AwayScore = awayScore;
        }

        public void FinishMatch()
        {
            IsFinished = true;
        }
    }
}