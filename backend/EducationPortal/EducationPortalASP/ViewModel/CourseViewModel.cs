using EducationPortalASP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.ViewModel
{
    public class CourseViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Bibliography { get; set; }
        [Required]
        public string HomeTask { get; set; }
        [Required]
        public string Dificult { get; set; }
        [Required]
        public string Price { get; set; }

        ICollection<Course> Courses { get; set; }
    }
}
