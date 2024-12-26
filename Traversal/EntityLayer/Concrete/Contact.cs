using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Contact
    {
        public int ContactId { get; set; }

        public string? Description { get; set; }

        public string? Email { get; set; }

        public string? Adress { get; set; }

        public string? Phone { get; set; }

        public string? MapInformation { get; set; }

        public bool? Status { get; set; }
    }
}
