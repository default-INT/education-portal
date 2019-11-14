using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Login { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не свопадают")]
        [DataType(DataType.Password)]
        [Display(Name ="Подтвердите пароль")]
        public string PasswordConfirm { get; set; }
    }
}
