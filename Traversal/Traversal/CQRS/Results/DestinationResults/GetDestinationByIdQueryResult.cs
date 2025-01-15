using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.CQRS.Results.DestinationResults
{
    public class GetDestinationByIdQueryResult
    {
        public int DestinationId { get; set; }

        public string? City { get; set; }

        public string? DayNight { get; set; }

        public double? Price { get; set; }
    }
}
