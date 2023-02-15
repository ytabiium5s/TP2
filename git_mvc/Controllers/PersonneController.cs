using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace git_mvc.Controllers
{
    public class PersonneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}