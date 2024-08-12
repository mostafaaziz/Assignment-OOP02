using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP02
{
    public enum Gender
    {
        M,
        F
    }

    [Flags]
    public enum SecurityPrivileges
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public HireDate HiringDate { get; set; }
        public Gender Gender { get; set; }
        public SecurityPrivileges SecurityLevel { get; set; }

        public Employee()
        {

        }

        public Employee(Employee _employee)
        {
            ID = _employee.ID;
            Name = _employee.Name;
            Salary = _employee.Salary;
            Gender = _employee.Gender;
            SecurityLevel = _employee.SecurityLevel;
            HiringDate = new HireDate(_employee.HiringDate);
        }

        public override string ToString()
        {
            return $"Employee ID: {ID}, Name: {Name}, Hiring Date {HiringDate}, Security Level: {SecurityLevel}, Gender: {Gender}, Salary: {Salary:C}";
        }

        public static Employee CreateEmployee(SecurityPrivileges security)
        {
            Employee employee = new Employee();

            employee.SecurityLevel = security;

            string? input;
            int id;
            do
            {
                Console.Write("Enter Employee ID: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out id));

            employee.ID = id;

            Console.Write("Enter Employee Name: ");
            employee.Name = Console.ReadLine();

            do
            {
                Console.Write("Enter Employee Salary: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out id));
            employee.Salary = id;

            employee.HiringDate = HireDate.CreateHiringDate();

            Gender G;
            do
            {
                Console.Write("Enter Employee Gender: ");
                input = Console.ReadLine();

            } while (!Enum.TryParse(input, out G));
            employee.Gender = G;

            return employee ;
        }

        public static Employee[] SortEmployees(Employee[] employees)
        {
            for(int i=0;i<employees.Length - 1; i++)
            {
                int min_Index = i;
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (HireDate.CompartHiringDate(employees[j].HiringDate, employees[min_Index].HiringDate))
                    {
                        min_Index = j;
                    }
                }

                if(min_Index != i)
                {
                    Employee temp = new Employee(employees[min_Index]);
                    employees[min_Index] = new Employee(employees[i]);
                    employees[i] = temp;
                }
            }
            return employees;
        }

    }
}
