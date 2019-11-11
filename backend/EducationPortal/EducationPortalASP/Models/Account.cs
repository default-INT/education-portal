using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.Models
{
    public class Account
    {
        public Account()
        {
            Users = new HashSet<User>();
            Administrators = new HashSet<Administrator>();
            Moderators = new HashSet<Moderator>();
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        public int? UserId { get; set; }
        public int? TeacherId { get; set; }
        public int? AdministratorId { get; set; }
        public int? ModeratorId { get; set; }


        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Administrator> Administrators { get; set; }
        public virtual ICollection<Moderator> Moderators { get; set; }

    }
}
