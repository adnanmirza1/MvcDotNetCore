using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1 , Name = "Mary" , Department = "HR"  , Email = "mary@yahoo.com"},
                new Employee(){Id = 2 , Name = "hary" , Department = "HR"  , Email = "hary@yahoo.com"},
                new Employee(){Id = 3 , Name = "pary" , Department = "HR"  , Email = "pary@yahoo.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
