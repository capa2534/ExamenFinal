using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.domain.Models.InputModels
{
    public class RegisterInputModel
    {
        [Required]
        [EmailAddress]
        [Remote(action: "checkemail", controller: "accounts", ErrorMessage = "Email already exists! Please try again with a different email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password Confirmation")]
        [Compare(otherProperty: "Password")]
        public string PasswordConfirmation { get; set; }
    }
}
