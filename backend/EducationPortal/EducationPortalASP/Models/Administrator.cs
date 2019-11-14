using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.Models
{
    public class Administrator : Account
    {
        public Administrator() { }
        public string FullName { get; set; }
    }
}
