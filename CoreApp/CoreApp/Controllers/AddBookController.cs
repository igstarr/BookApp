using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Controllers
{
    public class AddBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
