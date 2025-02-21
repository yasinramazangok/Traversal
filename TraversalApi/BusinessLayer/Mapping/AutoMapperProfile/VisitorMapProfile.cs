using AutoMapper;
using TraversalApi.DTOLayer.VisitorDTOs;
using TraversalApi.EntityLayer.Entities; // for Profile
namespace TraversalApi.BusinessLayer.Mapping.AutoMapperProfile
{
    public class VisitorMapProfile : Profile
    {
        public VisitorMapProfile()
        {
            // CreateMap<TSource, TDestination>()
            CreateMap<Visitor, ListVisitorDto>();
            CreateMap<Visitor, UpdateVisitorDto>().ReverseMap();
            CreateMap<Visitor, AddVisitorDto>().ReverseMap();
            CreateMap<Visitor, VisitorDto>().ReverseMap();
        }
    }
}
