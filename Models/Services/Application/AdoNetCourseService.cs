using System;
using System.Collections.Generic;
using System.Linq;
using MyCourse.Models.Services.Infrastractures;
using System.Data;

using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application
{
    public class AdoNetCourseService : ICourseService //servizio applicativo che ha il compito di recuperare dati dal database e lo fa tramite l utilizzo del servizio infrastrutturale IDatabaseAccessor
    {
        private readonly IDatabaseAccessor db; // proprieta che deve essere iniettata nel servizio applicativo

        public AdoNetCourseService(IDatabaseAccessor db) // dipendenza debole
        {
            this.db=db;
        }
        public List<CourseViewModel> GetCourses()
         {
            string query= "SELECT Id, Title,ImagePath, Author,Rating,FullPrice_Amount, FullPrice_Currency, CurrentPrice_Amount, CurrentPrice_Currency  FROM Courses";
            DataSet dataSet= db.Query(query);
            var dataTable= dataSet.Tables[0]; //recupera la prima tabella del dataset
            var courseList = new List<CourseViewModel>(); //crea la lista di corsi che deve eseere passata all view
            // per ogni riga presente nalla datatable deve creare un oggetto di tipo CourseViewModel 
            foreach(DataRow courseRow in dataTable.Rows)
            {
                CourseViewModel course = CourseViewModel.FromDataRow(courseRow);
                courseList.Add(course);
            }
            return courseList;
         }
      //  CourseDetailViewModel GetCourse(int id)
      //  {
            
       // }
    }
}