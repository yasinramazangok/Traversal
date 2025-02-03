using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Areas.Admin.Models
{
    public class VisitorViewModel
    {
        public int VisitorId { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public string? Email { get; set; }
    }
}
