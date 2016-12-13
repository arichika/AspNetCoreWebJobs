using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharedClassLibrary;

namespace AspNetCoreWebJob.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewData["result"] = await new MyClass().ToString("calling from AspNetCore");
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
