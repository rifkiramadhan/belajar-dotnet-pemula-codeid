using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.OOP.Challenges
{
    public abstract class Person
    {
        public string Nik { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public int Age
        {
            get
            {
                var _today = DateTime.Today;
                var _age = _today.Year - BirthDay.Year;
                
                if (BirthDay.Date > _today.AddYears(-_age))
                {
                    return _age--;
                };

                return _age;
            }
        }

        public abstract decimal TotalIncome();

        public string FullName => $"{FirstName} {LastName}";
    }

    public interface IEmployeeList
    {
        List<Employee> GetEmployeeList();
        decimal GetTotalSalary<Type>() where Type : Employee;
        Dictionary<string, int> GetTotalEmployeeByRole();
        int GetTotalEmployee();
        Dictionary<string, decimal> GetTotalSalaryByRole();
    }

    public class Employee : Person
    {
        public int EmpId { get; set; }
        public DateTime JoinDate { get; set; }
        public string Role { get; set; }
        public decimal BasicSalary { get; set; }

        public int TotalEmployee { get; set; }
        public decimal TotalSalary { get; set; }

        public override decimal TotalIncome()
        {
            return BasicSalary;
        }

        public virtual decimal GetTotalSalary()
        {
            TotalSalary += BasicSalary;
            return BasicSalary;
        }
    }

    public class Programmer : Employee
    {
        public decimal Transportasi { get; set; }

        public decimal GetTunjanganTransportasi()
        {
            return Transportasi;
        }

        public override decimal GetTotalSalary()
        {
            return BasicSalary + GetTunjanganTransportasi();
        }
    }

    public class Sales : Employee
    {
        public decimal Bonus { get; set; }
        public decimal Commission { get; set; }

        public decimal GetTunjanganSales()
        {
            return Bonus + Commission;
        }

        public override decimal GetTotalSalary()
        {
            return BasicSalary + GetTunjanganSales();
        }
    }

    public class QA : Employee
    {
        public decimal Makan { get; set; }

        public decimal GetTunjanganQA()
        {
            return Makan;
        }

        public override decimal GetTotalSalary()
        {
            return BasicSalary + GetTunjanganQA();
        }
    }

    public class Customer : Person
    {
        public string AccountNumber { get; set; }

        public override decimal TotalIncome()
        {
            return 0;
        }
    }

    public class Owner : Person
    {
        public int HasCompany { get; set; }

        public override decimal TotalIncome()
        {
            return HasCompany > 0 ? 1000000 : 0;
        }
    }

    public class EmployeeImpl : IEmployeeList
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            
            employees.Add(employee);
        }

        public List<Employee> GetEmployeeList()
        {
            return employees;
        }

        public decimal GetTotalSalary<Type>() where Type : Employee
        {
            return employees.OfType<Type>().Sum(e => e.GetTotalSalary());
        }

        public Dictionary<string, int> GetTotalEmployeeByRole()
        {
            return employees.GroupBy(e => e.Role).ToDictionary(g => g.Key, g => g.Count());
        }

        public int GetTotalEmployee()
        {
            return employees.Select(e => e.EmpId).Distinct().Count();
        }

        public Dictionary<string, decimal> GetTotalSalaryByRole()
        {
            return employees.GroupBy(e => e.Role).ToDictionary(g => g.Key, g => g.Sum(e => e.GetTotalSalary()));
        }
    }
}
