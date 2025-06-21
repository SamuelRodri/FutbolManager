namespace FutbolManager.Models
{
    public class TeamModel
    {
        public string Name { get; private set; }

        public TeamModel(string name)
        {
            Name = name;
        }
    }
}