using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Areas.Admin.Models
{
    public class ApiMovieViewModel
    {
        public int? Rank { get; set; }

        public string? Title { get; set; }

        public string? Rating { get; set; }

        public int? Year { get; set; }

        public string? Trailer { get; set; }
    }
}
