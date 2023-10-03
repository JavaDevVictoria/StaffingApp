using System.Globalization;

namespace StaffingApp
{
    class ProjectManager : Manager
    {
        private string projectName;

        public ProjectManager(string name, int id, DateTime dob, Employee[] team, string projectName)
            : base(name, id, dob, team)
        {
            this.projectName = projectName;
        }

        public string ProjectName
        {
            get { return projectName; }
        }

        public override void Manage()
        {
            Console.WriteLine($"{Name} is managing the project named {ProjectName}");
        }

        public override string ToString()
        {
            return $"ProjectManager{{name='{Name}', id={Id}, dob={Dob.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}, projectName='{projectName}', team={string.Join(", ", Team.Select(e => e.Name))}}}";
        }
    }
}
