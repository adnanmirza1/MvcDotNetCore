using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ApplicationController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private readonly UserManager<IdentityUser> userManager;

        public ApplicationController(IEmployeeRepository employeeRepository, UserManager<IdentityUser> userManager)
        {
            _employeeRepository = employeeRepository;
            this.userManager = userManager;
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

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteUser2(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("Users");
            }
        }
    }
}
