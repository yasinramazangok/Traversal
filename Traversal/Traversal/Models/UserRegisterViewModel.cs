﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresini giriniz")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="şifreler uyumlu değil!")]
        public string? ConfirmPassword { get; set; }
    }
}
