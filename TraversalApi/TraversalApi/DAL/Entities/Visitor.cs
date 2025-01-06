using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalApi.DAL.Entities
{
    public class Visitor
    {
        public int VisitorId { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public string? Email { get; set; }
    }
}
