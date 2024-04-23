using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.ViewModels;
using MyCourse.Models.ValueTypes;
using MyCourse.Models.Enums;

namespace MyCourse.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetCourses()
        {
            var courseList = new List<CourseViewModel>();
            var rand = new Random();
            for(int i = 1; i <= 20; i++){
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel{
                    Id = i,
                    Titolo = $"Corso {i}",
                    Autore = "Giorgia V",
                    ImgPath = "/logo.svg",
                    Rating = rand.Next(10,50)/10.0, //num decimale compreso fra 1 e 5
                    PrezzoFull = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price - 1),
                    PrezzoScontato = new Money(Currency.EUR, price)
                };
                courseList.Add(course);
            } 
            return courseList; 
        }

    }
}