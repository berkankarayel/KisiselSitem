﻿using Microsoft.AspNetCore.Mvc;

namespace KisiselSitem.Controllers
{
    public class LayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
