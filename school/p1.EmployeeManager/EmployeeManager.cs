using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walter_practises.school.EmployeeManager;

namespace walter_practises.school.p1.EmployeeManager
{
    internal class EmployeeManager : walter_practises.Interface.IManager
    {
        private readonly List<EmployeeModel> employees = new List<EmployeeModel>();
        

        public void Start()
        {
            Heading();
            EmployeeManager employeeManager = new EmployeeManager();

            while (true)
            {
                // Get name
                string name;

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------------------");
                    Console.WriteLine(" ADD NEW EMPLOYEE");
                    Console.WriteLine("-------------------");
                    Console.ResetColor();
                    Console.Write("Name (or press Enter to quit): ");
                    name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-----------------");
                        Console.WriteLine(" EMPLOYEES");
                        Console.WriteLine("-----------------");
                        Console.ResetColor();
                        var employees = employeeManager.GetAllEmployees();
                        foreach (var item in employees)
                        {
                            Console.WriteLine($"Name: {item.Name}, Salary: {item.Salary:C}");
                        }
                        return;
                    }

                    break;
                }

                if (employeeManager.EmployeeExists(name.Trim()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Employee already exists!");
                    Console.ResetColor();
                    Console.WriteLine();
                    continue;
                }

                // Get salary
                decimal salary;

                while (true)
                {
                    Console.Write("Salary: ");
                    string salaryInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(salaryInput))
                    {
                        Console.WriteLine("Salary is required.");
                        continue;
                    }

                    if (!decimal.TryParse(salaryInput, out salary))
                    {
                        Console.WriteLine("Salary must be a number.");
                        continue;
                    }

                    if (salary < 0)
                    {
                        Console.WriteLine("Salary must be 0 or higher.");
                        continue;
                    }

                    break;
                }

                walter_practises.school.EmployeeManager.EmployeeModel employee = new walter_practises.school.EmployeeManager.EmployeeModel
                {
                    Name = name,
                    Salary = salary
                };


                employeeManager.Create(employee);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Employee added!");
                Console.ResetColor();
                Console.WriteLine();
            }
    }

        public void Heading()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== WALTERS EMPLOYEE MANAGER ===");
            Console.ResetColor();
            Console.WriteLine(" Helping you handle your\r\n employee management");
            Console.WriteLine();
        }

        public void Create(EmployeeModel employee)
        {
            employees.Add(employee);
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return employees;
        }

        public bool EmployeeExists(string name)
        {
            var employees = GetAllEmployees();
            if (employees.Any())
            {
                if (employees.FirstOrDefault(x => x.Name == name) != null) { return true; }
            }
            return false;
        }
    }
}
