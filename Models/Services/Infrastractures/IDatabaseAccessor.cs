using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
namespace MyCourse.Models.Services.Infrastractures
{
    public interface IDatabaseAccessor // interfaccia che rappresenta il servizio infrastrutturale
    {
        DataSet Query(string query); // metodo che eseguira una query select passata come parametro
    }
}