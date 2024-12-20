using System.Data;
using OOPProject.Step05;
using OOPProject.Step05.Enum;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Summary Employee ====\n");

        // Inisialisasikan service dan panggil employee service
        IEmployeeService employeeService = new EmployeeService();
        var employees = employeeService.InitDataEmployee();

        // 1. Tampilkan seluruh data employee
        Console.WriteLine("1. Displaying All Employees:");
        Console.WriteLine("---------------------------");
        employeeService.DisplayEmployee(employees);
        Console.WriteLine();

        // 2. Total seluruh employe
        Console.WriteLine("2. Total Number of Employees:");
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total Employees: {employeeService.TotalEmployee(employees)}");
        Console.WriteLine();

        // 3. Hitung dan tampilkan total salary
        Console.WriteLine("3. Total Salary of All Employees:");
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total Salary: {employeeService.TotalSalary(employees):C}");
        Console.WriteLine();

        // 4. Panggil dan tampilkan employee dari id
        Console.WriteLine("4. Find Employee by ID (100-110):");
        Console.WriteLine("---------------------------");
        try
        {
            var employeeById = employeeService.GetById(employees, 131);
            Console.WriteLine($"Found Employee: {employeeById}");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        }
        Console.WriteLine();

        // 5. Panggil employee sesuai dengan role
        Console.WriteLine("5. Display Programmers Only:");
        Console.WriteLine("---------------------------");
        var allEmployees = employeeService.GetAll(employees);
        foreach (var emp in employees)
        {
            if (emp.Role == Roles.PROGRAMMER)
            {
                Console.WriteLine(emp);
            }
        }
        Console.WriteLine();

        // 6. Hitung gaji untuk karyawan tertentu
        Console.WriteLine("6. Salary Calculations:");
        Console.WriteLine("---------------------------");
        var employee = employees[0];
        var netSalary1 = employee.GetNetSalary(employee.BasicSalary, 10);
        var netSalary2 = employee.GetNetSalary(employee.BasicSalary, 10, 500);

        Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");
        Console.WriteLine($"Net Salary (with 10% tax): {netSalary1:NO}");
        Console.WriteLine($"Net Salary (with 10% tax and Rp 500 deduction): {netSalary2:NO}");
    }
}