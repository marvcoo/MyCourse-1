using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Models.ViewModels
{
    //classe che estende l'entità Corso, aggiungendo descrizione e lista di lezioni
    //che mi serviranno nella pagina di dettaglio
    public class CourseDetailViewModel : CourseViewModel
    {
        public string Descrizione {get; set;}
        public List<LessonViewModel> Lezioni {get; set;}
        public TimeSpan TotalCourseDuration
        {
            get => TimeSpan.FromSeconds(Lezioni?.Sum(l => l.Durata.TotalSeconds) ?? 0);
            /*l'operatore null-coalescing ??
            significa che se quello che c'è a sinistra è Null, allora restituisce 0
            altrimenti restituisce quello che c'è a sinistra (cioè la somma)
            */
        }
    }
}