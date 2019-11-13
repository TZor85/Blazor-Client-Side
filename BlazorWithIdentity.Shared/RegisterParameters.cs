using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorWithIdentity.Shared
{
    public class RegisterParameters
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "La contraseña no coincide")]
        public string PasswordConfirm { get; set; }

        [Required]
        public string NombreCompleto { get; set; }
    }
}
