using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicProject.OOP.Challenges;

namespace LogicProject.SOLID.Practice
{
    //internal class EmployeeSRP
    //{
    //    public long employeId;
    //    public string fullName;
    //    public DateTime hireDate;
    //    public double salary;
    //    public string empType;
    //    public Address address;

    //    // Bad
    //    public class Address
    //    {
    //        public string Street { get; set; }
    //        public string City { get; set; }
    //        public string State { get; set; }
    //        public string PostalCode { get; set; }
    //    }

    //    // getter setter

    //    // business logic
    //    public double calculateSalary(EmployeeSRP emp)
    //    {
    //        return 0.0;
    //    }

    //    public double calculateOvertime(EmployeeSRP emp)
    //    {
    //        return 0.0;
    //    }

    //    public double calculateTax(EmployeeSRP emp)
    //    {
    //        return 0.0;
    //    }

    //    public EmployeeSRP saveSRP(EmployeeSRP emp)
    //    {
    //        return null;
    //    }
    //    public EmployeeSRP updateSRP(EmployeeSRP emp)
    //    {
    //        return null;
    //    }
    //    public EmployeeSRP SRP(EmployeeSRP emp)
    //    {
    //        return null;
    //    }
    //}


    /*
        Hindari membuat God Class,
        dimana business logic &
        persistence logic disimpdan
        salam satu class
     */

    // Good
    //internal class EmployeeSRP
    //{
    //    private long employeId;
    //    private string fullName;
    //    private DateTime hireDate;
    //    private double salary;
    //    private string empType;
    //    private Address address;

    //    // Bad
    //    public class Address
    //    {
    //        public string Street { get; set; }
    //        public string City { get; set; }
    //        public string State { get; set; }
    //        public string PostalCode { get; set; }
    //    }

    //    public class EpmloyeeService
    //    {
    //        // business logic
    //        public double calculateSalary(EmployeeSRP emp)
    //        {
    //            return 0.0;
    //        }

    //        public double calculateOvertime(EmployeeSRP emp)
    //        {
    //            return 0.0;
    //        }

    //        public double calculateTax(EmployeeSRP emp)
    //        {
    //            return 0.0;
    //        }
    //    }

    //    public class EmployeeDAO
    //    {
    //        public EmployeeSRP saveSRP(EmployeeSRP emp)
    //        {
    //            return null;
    //        }
    //        public EmployeeSRP updateSRP(EmployeeSRP emp)
    //        {
    //            return null;
    //        }
    //        public EmployeeSRP SRP(EmployeeSRP emp)
    //        {
    //            return null;
    //        }
    //    }

    //}
}
