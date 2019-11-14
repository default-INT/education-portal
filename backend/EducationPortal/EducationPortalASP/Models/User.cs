using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.Models
{
    public class User : Account
    {
        public string FullName { get; set; } //ФИО
        public string Skills { get; set; } 
        public string Rating { get; set; }
        public string Sertificate { get; set; }
        public double Dificult { get; set; }

        
        public virtual ICollection<UserCourse> Courses { get; set; }
        public User()
        {
            Courses = new HashSet<UserCourse>();
        }
    }
}
