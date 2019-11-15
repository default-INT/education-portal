using EducationPortalASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.ViewModel
{
    public class ProfileViewModel
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Skills { get; set; }
        public double Rating
        {
            get
            {
                return new Random().Next(1, 100) / 10;
            }
        }
        public string Sertificate { get; set; }
        public string Education { get; set; }

        public IQueryable<Course> Courses { get; set; }
    }
}
