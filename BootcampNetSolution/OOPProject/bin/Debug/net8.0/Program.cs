using System.Data;
using OOPProject.Step01;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create object use empty constructor
        Employee emp1 = new Employee();
        emp1.EmpId = 1;
        emp1.FirstName = "Test";
        emp1.LastName = "Code";
        emp1.JoinDate = new DateTime(2021, 12, 12);
        emp1.Role = "Programmer";
        emp1.BasicSalary = 9_000;


        // Create obejct using constructor
        var emp2 = new Employee(101, "Kang", "Dian", new DateTime(2020, 1, 10), emp1.Role, 10_000);
        var emp3 = new Employee(102, "Wini", "Widi", new DateTime(2020, 1, 10), emp1.Role, 11_000);
        var emp4 = new Employee(103, "Rini", "Mini", new DateTime(2020, 1, 10), emp1.Role, 12_000);
        var emp5 = new Employee(104, "Yuli", "Yuliana", new DateTime(2020, 1, 10), emp1.Role, 10_000);

        List<Employee> employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5 };

        // Display Employees
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.ToString());
        }

        Console.WriteLine($"Total Salary: {emp5.GetTotalSalary(employees)}");
    }
}