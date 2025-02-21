using TraversalApi.BusinessLayer.Abstracts;
using TraversalApi.DTOLayer.VisitorDTOs;
using TraversalApi.EntityLayer.Entities;

namespace TraversalApi.BusinessLayer.Abstract
{
    public interface IVisitorService : IGenericService<VisitorDto, AddVisitorDto, UpdateVisitorDto, ListVisitorDto>
    {
    }
}
