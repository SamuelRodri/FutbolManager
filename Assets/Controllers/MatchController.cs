using FutbolManager.Models;
using FutbolManager.Views;
using UnityEngine;

namespace FutbolManager.Controllers
{
    public class MatchController : MonoBehaviour
    {
        private MatchModel _matchModel;
        [SerializeField] private MatchView _matchView;

        private void Start()
        {
            // Match inicial de test
            TeamModel homeTeam = new TeamModel("Home Team");
            TeamModel awayTeam = new TeamModel("Away Team");

            SetMatch(new MatchModel(homeTeam, awayTeam));
            SimulateMatch();
        }

        public void SetMatch(MatchModel matchModel)
            => _matchModel = matchModel;

        public void SimulateMatch()
        {
            if (_matchModel != null)
            {
                // Simula un partido simple
                _matchModel.SetScore(Random.Range(0, 5), Random.Range(0, 5));
                _matchModel.FinishMatch();

                _matchView.UpdateView(
                    _matchModel.HomeTeam.Name,
                    _matchModel.AwayTeam.Name,
                    _matchModel.HomeScore,
                    _matchModel.AwayScore
                );
            }
            else
            {
                Debug.LogError("Match model is not set.");
            }
        }
    }
}