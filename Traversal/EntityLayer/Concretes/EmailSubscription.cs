using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.EntityLayer.Concretes
{
    public class EmailSubscription
    {
        public int EmailSubscriptionId { get; set; }

        public string? Email { get; set; }
    }
}
