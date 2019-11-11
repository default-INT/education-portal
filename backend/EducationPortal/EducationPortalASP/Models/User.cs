using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.Models
{
    public class User : Account
    {
        public User() {
            Courses = new HashSet<Course>();
        }
        public string FullName { get; set; }
        public string Skills { get; set; } //-> enum, class 
        public string Rating { get; set; }
        public string Sertificate { get; set; }
        public int CourseId { get; set; }

        [InverseProperty("Users")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
