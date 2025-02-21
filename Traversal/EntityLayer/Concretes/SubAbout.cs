using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.EntityLayer.Concretes
{
  public  class SubAbout
    {
        public int SubAboutId { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }
    }
}
