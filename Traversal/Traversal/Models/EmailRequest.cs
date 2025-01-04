using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Models
{
    public class EmailRequest
    {
        public string Name { get; set; }

        public string EmailSender { get; set; }

        public string EmailReceiver { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }
    }
}
