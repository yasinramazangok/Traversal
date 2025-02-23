using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DTOLayer.AdminDTOs.AnnouncementDtos
{
    public class UpdateAnnouncementDto
    {
        public int AnnouncementId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? Date { get; set; }
    }
}
