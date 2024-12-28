using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public string? PersonCount { get; set; }

        public DateTime? Date { get; set; }

        public string? Description { get; set; }

        public string? Status { get; set; }

        public int? TraversalUserId { get; set; }

        public TraversalUser? TraversalUser { get; set; }

        public int? DestinationId { get; set; }

        public Destination? Destination { get; set; }
    }
}
