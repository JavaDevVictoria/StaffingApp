namespace StaffingApp
{
    abstract class Manager : Employee
    {
        protected Employee[] team;

        public Manager(string name, int id, DateTime dob, Employee[] team) : base(name, id, dob)
        {
            this.team = team;
        }

        public Employee[] Team
        {
            get { return team; }
            set { team = value; }
        }

        // Abstract method
        public abstract void Manage();
    }
}
