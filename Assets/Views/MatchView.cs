using TMPro;
using UnityEngine;

namespace FutbolManager.Views
{
    public class MatchView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _homeTeamName;
        [SerializeField] private TMP_Text _awayTeamName;
        [SerializeField] private TMP_Text _homeScore;
        [SerializeField] private TMP_Text _awayScore;

        public void UpdateView(string homeTeamName, string awayTeamName, int homeScore, int awayScore)
        {
            _homeTeamName.text = homeTeamName;
            _awayTeamName.text = awayTeamName;
            _homeScore.text = homeScore.ToString();
            _awayScore.text = awayScore.ToString();
        }
    }
}
