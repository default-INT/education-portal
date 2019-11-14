using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortalASP.ViewModel
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Required]
        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не свопадают")]
        [DataType(DataType.Password)]
        [Display(Name ="Подтвердите пароль")]
        public string PasswordConfirm { get; set; }

        [Required]
        [Display(Name = "Навыки")]
        public string Skills { get; set; }

        [Required]
        [Display(Name = "Сертификат")]
        public string Sertificate { get; set; }

        [Required]
        [Display(Name = "Образование")]
        public string Education { get; set; }
    }
}
