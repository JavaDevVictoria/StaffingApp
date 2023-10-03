using System.Globalization;

namespace StaffingApp
{
    class TeamManager : Manager
    {
        private string teamName;

        public TeamManager(string name, int id, DateTime dob, Employee[] team, string teamName)
            : base(name, id, dob, team)
        {
            this.teamName = teamName;
        }

        public string TeamName
        {
            get { return teamName; }
        }

        public override void Manage()
        {
            Console.WriteLine($"{Name} is managing the team named {TeamName}");
        }

        public override string ToString()
        {
            return $"TeamManager{{name='{Name}', id={Id}, dob={Dob.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}, teamName='{teamName}', team={string.Join(", ", Team.Select(e => e.Name))}}}";
        }
    }
}
