using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTO.ContactDTO
{
    public class SendMessageDto
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Subject { get; set; }

        public string? Message { get; set; }

        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}
