using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.SOLID.Challenges
{
    internal class EmployeeSOLID
    {
        public class Employee
        {
            public int EmpNo { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime HireDate { get; set; }
            public string EmpType { get; set; }
            public decimal Salary { get; set; }
            public decimal Bonus { get; set; }
            public decimal SelfInsurannce { get; set; }
            public decimal DependenntInsurnce { get; set; }
            public string MedicalInsurance { get; set; }
            public int OvertimeHours { get; set; }
            public decimal Overtime { get; set; }
            public decimal AllowanceDay { get; set; }
            public decimal AllowanceLunch { get; set; }
            public decimal AllowanceTransport { get; set; }
            public string TaxPPH { get; set; }
            public string TaxTapera { get; set; }
            public decimal TotalInsurance { get; set; }
            public decimal TotalOvertime { get; set; }
            public decimal TotalAllowance { get; set; }
            public decimal TotalTax { get; set; }
            public decimal TotalSalary { get; set; }
            public decimal EndOfYearSalary { get; set; }
        }

        public interface IEmployeeService
        {
            decimal GetTotalInsurance();
            decimal GetTotalOvertime();
            decimal GetTotalAllowance();
            decimal GetTotalTax();
            decimal GetTotalSalary();
            decimal GetTotalEndOfYearSalary();
        }

        public class EmployeeServiceImpl : IEmployeeService
        {
            private readonly List<Employee> _employees;

            public EmployeeServiceImpl(List<Employee> employees)
            {
                _employees = employees ?? new List<Employee>();
            }

            public decimal GetTotalInsurance()
            {
                return _employees.Sum(e => e.TotalInsurance);
            }

            public decimal GetTotalOvertime()
            {
                return _employees.Sum(e => e.TotalOvertime);
            }

            public decimal GetTotalAllowance()
            {
                return _employees.Sum(e => e.TotalAllowance);
            }

            public decimal GetTotalTax()
            {
                return _employees.Sum(e => e.TotalTax);
            }

            public decimal GetTotalSalary()
            {
                return _employees.Sum(e => e.TotalSalary);
            }

            public decimal GetTotalEndOfYearSalary()
            {
                return _employees.Sum(e => e.EndOfYearSalary);
            }

            public List<Employee> GetEmployees() => _employees;
            public int GetTotalEmployees() => _employees.Count;
        }
    }
}
