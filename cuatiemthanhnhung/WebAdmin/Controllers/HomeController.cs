using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
   [Authorize] 
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
