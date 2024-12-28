using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string? Name { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? ConfirmPassword { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? Imageurl { get; set; }

        public IFormFile? Image { get; set; }

    }
}
