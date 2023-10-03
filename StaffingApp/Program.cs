using System.Text;

namespace StaffingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create employees
            Employee e1 = new Employee("John Grennan", 1001, new DateTime(1978, 10, 12));
            Employee e2 = new Employee("Rebecca Wilson", 1002, new DateTime(1995, 3, 7));
            Employee e3 = new Employee("Amy Kim", 1003, new DateTime(1980, 7, 23));

            // Create team
            Employee[] team = { e1, e2 };

            // Create Project Manager
            ProjectManager pm = new ProjectManager("Tom Smith", 2001, new DateTime(1985, 4, 26), team, "Mobile Responsive Project");

            pm.Manage();

            // Create Team Manager
            TeamManager tm = new TeamManager("Daisy Johnson", 3001, new DateTime(1983, 11, 23), team, "Web Development Team");

            tm.Manage();

            // Create List of employees
            List<Employee> employees = new List<Employee> { e1, e2, e3 };

            // Create department and use polymorphism with the MyPrintable interface
            MyPrintable printable = new Department("Research and Development", pm, employees);
            printable.Print();

            // Use exception handling
            try
            {
                int d = 10;  // CHANGE THIS TO SOMETHING RELEVANT
                int result = d / 0;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException caught: Cannot divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!");
            }
            finally
            {
                Console.WriteLine("Continuing...");
            }

            // Use StringBuilder - print names on one line
            StringBuilder sb = new StringBuilder();
            foreach (Employee employee in employees)
            {
                sb.Append(employee.Name + " ");
            }
            Console.WriteLine(sb.ToString());

            // Use lambda expression
            employees = employees.OrderBy(emp => emp.Name).ToList();
            employees.ForEach(emp => Console.WriteLine(emp.Name));

            // Use System.DateTime to calculate age of employees
            DateTime now = DateTime.Now;

            // Enhanced for-loop
            foreach (Employee employee in employees)
            {
                TimeSpan age = now - employee.Dob;
                int years = age.Days / 365;
                Console.WriteLine($"Age of {employee.Name}: {years} years");
            }

            // Print employee count using static variable
            Console.WriteLine("Employee count: " + Employee.count);
        }
    }
}