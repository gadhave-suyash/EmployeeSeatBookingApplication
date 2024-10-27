using System.Collections.Generic;
using EmployeeSeatBookingApplication.Models;

namespace EmployeeSeatBookingApplication.Controllers
{
    public class EmployeeController
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}