using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeGardenWebApp.Models
{
    public class RegistroViewModel
    {
        [Required]
        [Display(Name = "Nome")]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação de senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmaçãos de senha digitadas não correspondem.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
    }
}