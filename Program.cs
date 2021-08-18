using System;
using System.Collections.Generic;

namespace Assignment5
{
    public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
    public class Employee
    {
        public static readonly object empolyee;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public static object Program { get; private set; }
    
        public static void PromoteEmployee(List<Employee> lstEmployees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (Employee employee in lstEmployees)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} Promoted", employee.Name);
                }
            }
        }

       public static void Main()
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Jenny",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priya",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Sonali",
                Experience = 15,
                Salary = 30000
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Advik",
                Experience = 20,
                Salary = 50000
            };

            List<Employee> lstEmployess = new List<Employee>
            {
                emp1,
                emp2,
                emp3,
                emp4
            };
            EligibleToPromotion eligibleTopromote = new EligibleToPromotion(Promote);
            Employee.PromoteEmployee(lstEmployess, eligibleTopromote);
        }
        public static bool Promote(Employee employee)
        {
            if (employee.Salary <= 10000 || employee.Experience <= 10 )
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}







