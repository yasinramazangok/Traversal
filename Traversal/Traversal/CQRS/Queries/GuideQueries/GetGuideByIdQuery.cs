using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.CQRS.Results.GuideResults;

namespace Traversal.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery : IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
