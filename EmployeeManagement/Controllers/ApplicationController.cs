using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ApplicationController : Controller
    {
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
            return View();
        }
    }
}
