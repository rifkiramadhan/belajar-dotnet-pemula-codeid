using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.SOLID.Practice
{
    //internal class EmployeeOCP
    //{
    //    // Bad
    //    public class EmployeeService
    //    {
    //        // business logic
    //        public class calculateSalary(EmployeeOCP emp)
    //        {
    //            double salary = 0.0;

    //            if (emp.getEmpType().equals("PERMANENT")){
    //                salary = emp.getSalary() + emp.getMedical();
    //            } else if (emp.getEmpType().euals("CONTRACT") {
    //                salary = emp.getSalary() + emp.getWorkTime();
    //            }

    //        return salary;
    //        }
    //    }
    //}

    /*
        Hindari penggunaan
        condition if else, karena jika 
        ada requirement baru, kita
        harus ubah code kita

        Tapi...

        Gunakan interface, pastikan 
        bahwa class dapat kita
        tambah/ubah method-nya
        berdasarkan method-method
        yang ada di interface
    */

    //internal class EmployeeOCP
    //{
    //    // GOOD
    //    public class EmployeeService
    //    {
    //        // business logic
    //        public interface EmployeeService
    //        {
    //            public double calculateSalary();
    //        }

    //        public class PermanentEmployee implements EmployeeService
    //        {
    //            @verride
    //            public double calculateSalary()
    //            {
    //                return (salary + medical)
    //            }
    //        }
    //    }

    //    public class ContractEmployee implements EmployeeService
    //    {
    //            @verride
    //            public double calculateSalary()
    //            {
    //                return (salary + workTime)
    //            }
    //    }
    //}
}