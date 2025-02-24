using AutoMapper;
using Traversal.DTOLayer.AdminDTOs.AccountDtos;
using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;
using Traversal.DTOLayer.AdminDTOs.DestinationDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Mapping.AutoMapperProfile
{
    public class AdminMapProfile : Profile
    {
        public AdminMapProfile()
        {
            CreateMap<BalanceTransferDto, List<Account>>();

            CreateMap<AddAnnouncementDto, Announcement>().ReverseMap();
            CreateMap<UpdateAnnouncementDto, Announcement>().ReverseMap();
            CreateMap<AnnouncementDto, Announcement>().ReverseMap();
            CreateMap<ListAnnouncementDto, Announcement>().ReverseMap();

            CreateMap<AddDestinationDto, Destination>().ReverseMap();
            CreateMap<UpdateDestinationDto, Destination>().ReverseMap();
            CreateMap<DestinationDto, Destination>().ReverseMap();
            CreateMap<ListDestinationDto, Destination>().ReverseMap();
        }
    }
}
