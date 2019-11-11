using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EducationPortalASP.Models
{
    public class EducationPortalContext : DbContext
    {
        public EducationPortalContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Moderator> Moderators { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCourse> UserCourses { get; set; }
       
    }
}
