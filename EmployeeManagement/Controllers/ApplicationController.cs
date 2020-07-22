using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ApplicationController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public ApplicationController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Authorize]
        public IActionResult Management()
        {
            return View();
        }
        [Authorize]
        public IActionResult Settings()
        {
            return View();
        }
        [Authorize]
        public IActionResult Users()
        {
            // retrieve all the employees
            var model = _employeeRepository.GetAllEmployees();
            // Pass the list of employees to the view
             return View(model);
            
        }
    }
}
