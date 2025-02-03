using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.CQRS.Results.GuideResults
{
    public class GetGuideByIdQueryResult
    {
        public int GuideId { get; set; }

        public string? Name { get; set; }
        
        public string? Description { get; set; }
    }
}
