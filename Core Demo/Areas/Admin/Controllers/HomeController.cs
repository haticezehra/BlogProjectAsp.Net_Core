﻿using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
