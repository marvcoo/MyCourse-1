using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService CourseService; //oggetto che deve essere automaticamente iniettato da asp.netcore 
        //quando viene invocato questo controller
        //è una interfaccia per realizzare il disaccoppiamento debole (dependency injection)
        public CoursesController(ICourseService courseService)
        {
            //verrà iniettato automaticamente un oggetto di una classe che implementa l'interfaccia ICourseService
            this.CourseService = courseService;
        }


        //metodo per recuperare la lista di tutti i corsi
        public IActionResult Index() 
        {
            //var courseService = new CourseService(); //invocazione del servizio
            //la creazione dell'oggetto (servizio) non serve più perchè tramite l'injection, asp.net core lo fa in automatico
            
            List<CourseViewModel> courses = CourseService.GetCourses();
            ViewData["Title"] = "Elenco dei corsi";
            return View(courses); //ritorna la lista di tutti i corsi
        }

        //metodo che deve recuperare le info dello specifico corso avente un certo id
        public IActionResult Detail(int id)
        {
            //var courseService = new CourseService(); //invocazione del servizio
            //la creazione non serve più perchè tramite l'injection, asp.net core lo fa in automatico
            
            CourseDetailViewModel viewModel = CourseService.GetCourse(id);
            ViewData["Title"] = viewModel.Titolo;
            return View(viewModel);
            //return Content($"Sono Detail, ho ricevuto l'id {id}");
            //return Redirect("https://www.amazon.it/");
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}