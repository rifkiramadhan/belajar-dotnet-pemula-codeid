using System.Data;
using OOPProject.Step04;
using OOPProject.Step04.Enum;

internal class Program
{
    private static void Main(string[] args)
    {
        // Final Design, using interface
        IEmployeeService employeeService = new EmployeeService();
        var employees = employeeService.InitDataEmployee();
        employeeService.DisplayEmployee(employees);

        var emp5 = new Employee("134", "Yuli", "Yuliana", "yuli@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);
        var netSal1 = emp5.GetNetSalary(emp5.BasicSalary, 10);
        var netSal2 = emp5.GetNetSalary(emp5.BasicSalary, 10, 500);
 
        // Create object use empty constructor
        //Employee emp1 = new Employee();
        //emp1.EmpId = 1;
        //emp1.FirstName = "Test";
        //emp1.LastName = "Code";
        //emp1.JoinDate = new DateTime(2021, 12, 12);
        //emp1.Role = Roles.HR;
        //emp1.BasicSalary = 9_000;

        // Create obejct using constructor
        //var emp2 = new Employee("131", "Kang", "Dian", "kang@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);
        //var emp3 = new Employee("132", "Wini", "Widi", "wini@gmail.com", new DateTime(1999, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 11_000);
        //var emp4 = new Employee("133", "Rini", "Mini", "rini@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 12_000);
        //var emp5 = new Employee("134", "Yuli", "Yuliana", "yuli@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);

        // Call object programmer
        //var emp6 = new Programmer("135", "Asep", "Budi", "asep_budi@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000, 5_000);
        //emp6.BasicSalary = 15_000;

        // Create object using constructor
        //List<Employee> employees = new List<Employee>() { emp2, emp3, emp4, emp5, emp6 };

        // Display Employees
        //foreach (Employee emp in employees)
        //{
        //    Console.WriteLine(emp.ToString());
        //}

        //Console.WriteLine($"Total Salary: {Employee.GetTotalSalary(employees)}");
    }
}