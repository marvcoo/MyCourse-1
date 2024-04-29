using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application
{
    //questa interfaccia include i metodi che un servizio,
    //per poter essere compatibile con il controller;
    //deve implementare affinchè funzioni
    public interface ICourseService
    {
        List<CourseViewModel> GetCourses();
<<<<<<< HEAD
        CourseDetailViewModel GetCourse(int id);
        List<CourseViewModel> Ricerca(string cerca);
=======
       // CourseDetailViewModel GetCourse(int id);
        

>>>>>>> 8e22fd6496c47db7d8aafae37bb74fa5bd897348
    }
}