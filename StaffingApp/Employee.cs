namespace StaffingApp
{
    class Employee
    {
        private string name;
        private int id;
        private DateTime dob;

        public static int count = 0;

        // Static constructor (C# equivalent of static initializer)
        static Employee()
        {
            Console.WriteLine("Employee class loaded");
        }

        public Employee(string name, int id, DateTime dob)
        {
            this.name = name;
            this.id = id;
            this.dob = dob;
            count++;
        }

        public string Name
        {
            get { return name; }
        }

        public int Id
        {
            get { return id; }
        }

        public DateTime Dob
        {
            get { return dob; }
        }

        public override string ToString()
        {
            return "Employee{" +
                "name='" + name + '\'' +
                ", id=" + id +
                ", dob=" + dob +
                '}';
        }
    }
}
