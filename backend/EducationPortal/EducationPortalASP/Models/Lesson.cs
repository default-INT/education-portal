using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descript { get; set; }
        public double Dificult { get; set; }

        public virtual Course Course { get; set; } //навигационное свойство
    }
}
