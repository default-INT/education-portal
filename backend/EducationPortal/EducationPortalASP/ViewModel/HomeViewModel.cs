using EducationPortalASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.ViewModel
{
    public class HomeViewModel
    {
        public Account User { get; set; }
        public IQueryable<Course> Courses { get; set; }
        public Course CourseItem { get; set; }
    }
}
