using System.Globalization;
using OOPProject.Step04.Enum;

namespace OOPProject.Step04
{
    internal class Employee : Person
    {
        public Employee(string nationalId, string firstName, string lastName, string email, DateTime birthDay, DateTime joinDate, Roles role, decimal basicSalary) 
        : base(nationalId, firstName, lastName, email, birthDay)
        {
            Random random = new Random();
            EmpId = random.Next(100, 111);
            JoinDate = joinDate;
            BasicSalary = basicSalary;
            Role = role;
        }

        // Property Video 05
        public int EmpId { get; set; }

        public DateTime JoinDate {get; set;}

        public Roles Role { get; set; }

        public virtual decimal BasicSalary { get; set; }

        public decimal TotalSalary { get; set; }

        // Implement Polymorphism Method Overloading
        public decimal GetNetSalary(decimal salary, double tax)
        {
            var taxProsen = (decimal)tax / 100;
            return salary + salary * taxProsen;
        }

        public double GetNetSalary(decimal salary, double tax, double potongan)
        {
            var taxProsen = tax / 100;
            return ((double)salary + taxProsen) - potongan;
        }

        public static decimal GetTotalSalary(List<Employee> empList)
        {
            decimal totalSalary = 0;

            foreach (Employee emp in empList)
            {
                totalSalary += emp.TotalSalary;
            }

            return totalSalary;
        }

        public override string? ToString()
        {
            return $"{base.ToString()}| EmpId: {EmpId} | FullName: {FirstName + " " + LastName} | " +
                   $"JoinDate: {JoinDate} | Role: {Role} | BasicSalary: {BasicSalary.ToString("C", new CultureInfo("id-ID"))} ";
        }
    }
}
