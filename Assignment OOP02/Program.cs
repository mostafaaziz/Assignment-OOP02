namespace Assignment_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q6
            Employee[] employees = new Employee[3];

            employees[0] = Employee.CreateEmployee(SecurityPrivileges.DBA);
            employees[1] = Employee.CreateEmployee(SecurityPrivileges.Guest);
            employees[2] = Employee.CreateEmployee(SecurityPrivileges.DBA | SecurityPrivileges.Guest | SecurityPrivileges.Developer | SecurityPrivileges.Secretary);
            
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            #endregion



            #region Q7

            employees = Employee.SortEmployees(employees);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            #endregion

        }
    }
}
