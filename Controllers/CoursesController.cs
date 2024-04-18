using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public CoursesController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(string id)
        {
            if (id == "5")
            return View("Prova");
            else 
            return View();
            //return Content($"Sono Detail, ho ricevuto l'id {id}");
            //return Redirect("https://www.amazon.it/");
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}