using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace stateMgmtDemo
{
    public class EmployeeDB
    {
        public ArrayList GetEmployee()
        {
            Employee e1 = new Employee { EmpID = 1, EmpName = "Ankit Patel", Address = "Surat", EmailAddress = "Ankit.patel@target.com", Salary = 5000 };
            Employee e2 = new Employee { EmpID = 5, EmpName = "Snehal Patel", Address = "Bangalore", EmailAddress = "Snehal@target.com", Salary = 2000 };
            Employee e3 = new Employee { EmpID = 10, EmpName = "Vimal Patel", Address = "Bangalore", EmailAddress = "Vimal@target.com", Salary = 4300 };
            Employee e4 = new Employee { EmpID = 100, EmpName = "Pintu Patel", Address = "USA", EmailAddress = "Pintu@target.com", Salary = 3000 };
            Employee e5 = new Employee { EmpID = 125, EmpName = "Hiren Patel", Address = "Velanja", EmailAddress = "Hiren@target.com", Salary = 9000 };
            return new ArrayList { e1, e2, e3, e4, e5 };
        }


        public Employee GetEmployee(int empId)
        {

            Employee employee = null;
            foreach (Employee emp in GetEmployee())
            {
                if (emp.EmpID == empId)
                {
                    employee = emp;
                }
            }
            return employee;
        }
    }
}