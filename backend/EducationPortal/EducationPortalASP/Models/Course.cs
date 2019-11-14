using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; } //преподаватель
        public string Subject { get; set; }
        public double Rating { get; set; }
        public string Bibliography { get; set; } //сисок литературы
        public string HomeTask { get; set; } //домашнее задание link gitHub
        public DateTime StartDate { get; set; } //дата начала курса
        public DateTime EndDate { get; set; } //дата конца курса
        public string Descript { get; set; }
        public double Dificult { get; set; } //сложность от 1 до 10
        public double Price { get; set; }

        
        public virtual ICollection<UserCourse> Users { get; set; } //студенты
        public virtual ICollection<Lesson> Lessons { get; set; }
        public Course()
        {
            Users = new HashSet<UserCourse>();
        }
    }
}
