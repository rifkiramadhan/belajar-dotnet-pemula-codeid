using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPProject.Step05.Enum;

namespace OOPProject.Step05
{
    internal class EmployeeService : IEmployeeService
    {
        public void DisplayEmployee(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        public List<Employee> GetAll(List<Employee> employees)
        {
            // Membuat list employee baru
            return new List<Employee>(employees);
        }

        public Employee GetById(List<Employee> employees, int id)
        {
            // Jika tersedia maka munculkan
            var employee = employees.FirstOrDefault(emp => emp.EmpId == id);
            
            // Jika tidak maka tampilkan errornya
            if (employee == null)
            {
                throw new KeyNotFoundException($"Employee with ID {id} not found!.");
            }

            return employee;
        }

        public List<Employee> InitDataEmployee()
        {
            // Create obejct using constructor
            var emp2 = new Employee("131", "Kang", "Dian", "kang@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);
            var emp3 = new Employee("132", "Wini", "Widi", "wini@gmail.com", new DateTime(1999, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 11_000);
            var emp4 = new Employee("133", "Rini", "Mini", "rini@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 12_000);
            var emp5 = new Employee("134", "Yuli", "Yuliana", "yuli@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);

            // Call object programmer
            var emp6 = new Programmer("135", "Asep", "Budi", "asep_budi@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000, 5_000);

            return new List<Employee>() { emp2, emp3, emp4, emp5, emp6 };
        }

        public int TotalEmployee(List<Employee> employees)
        {
            // Menampilkan seluruh total employee
            return employees?.Count ?? 0;
        }

        public double TotalSalary(List<Employee> employees)
        {
            if (employees == null || !employees.Any())
            {
                return 0;
            }

            // Hitung total salary untuk seluruh employee
            decimal totalSalary = 0;
            foreach (var employee in employees)
            {
                if (employee is Programmer programmer)
                {
                    // Jika programmer, sertakan tunjangan transportasinya
                    totalSalary += programmer.TotalSalary;
                }
                else
                {
                    // Jika employee, pakai saja gaji pokoknya
                    totalSalary += employee.BasicSalary;
                }
            }

            // Ubah menjadi double sesuai method
            return (double)totalSalary;
        } 
    }
}
