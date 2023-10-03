namespace StaffingApp
{
    class Department : MyPrintable
    {
        private string name;
        private Manager manager;
        private List<Employee> employees;

        public Department(string name, Manager manager, List<Employee> employees)
        {
            this.name = name;
            this.manager = manager;
            this.employees = employees;
        }

        public string Name
        {
            get { return name; }
        }

        public Manager Manager
        {
            get { return manager; }
        }

        public List<Employee> Employees
        {
            get { return employees; }
        }

        public void Print()
        {
            Console.WriteLine("Department Name: " + name);
            Console.WriteLine("Manager: " + manager.ToString());
            Console.WriteLine("Employees: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
