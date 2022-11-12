using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        public int GetFilteredEmployeesCount(DateTime start, DateTime end, double salary)
        {
            Employee[] employees = GetEmployees();

            int empCount = 0;

            foreach (Employee emp in employees)
            {
                if ((emp.Birthday> start && emp.Birthday < end) && emp.Salary>salary)
                {
                    empCount++;
                }
                
            }
            return empCount;
            
        }
        private Employee[] GetEmployees()
        {
            Employee emp1 = new Employee(DateTime.Now.AddDays(20));
            emp1.Salary = 5000;
            Employee emp2 = new Employee(DateTime.Now.AddDays(15));
            emp2.Salary = 7500;
            Employee emp3 = new Employee(DateTime.Now.AddDays(-20));
            emp3.Salary = 800;
            Employee emp4 = new Employee(DateTime.Now.AddDays(-10));
            emp4.Salary = 1000;
            Employee emp5 = new Employee(DateTime.Now);
            emp5.Salary = 6000;

            Employee[] employees = { emp1, emp2, emp3, emp4, emp5 };

            return employees;
        }
    }
}
