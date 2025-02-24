using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DTOLayer.AdminDTOs.AboutDtos
{
    public class ListAboutDto
    {
        public int AboutId { get; set; }
        public string? Title { get; set; }
        public string? Title2 { get; set; }
        public string? Description { get; set; }
        public string? Description2 { get; set; }
        public string? Image { get; set; }
        public bool? Status { get; set; }
    }
}
