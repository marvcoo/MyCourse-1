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
<<<<<<< HEAD
        CourseDetailViewModel GetCourse(int id);
        List<CourseViewModel> Ricerca(string cerca);
=======
       // CourseDetailViewModel GetCourse(int id);
=======
        CourseDetailViewModel GetCourse(int id);
>>>>>>> 9384bf0ba6e3d42b988cc7a3f7076b5c3ae59fda
        

>>>>>>> 8e22fd6496c47db7d8aafae37bb74fa5bd897348
    }
}