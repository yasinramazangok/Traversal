using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz!")]
        public string? Username { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz!")]
        public string? Password { get; set; }
    }
}
