using AutoMapper;
using DTOLayer.DTO.AnnouncementDto;
using DTOLayer.DTO.ContactDTO;
using DTOLayer.DTO.TraversalUserDto;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<TraversalUserRegisterDto, TraversalUser>();
            CreateMap<TraversalUser, TraversalUserRegisterDto>();

            CreateMap<AnnouncementAddDto, Announcement>();
            CreateMap<Announcement, AnnouncementAddDto>();

            CreateMap<AnnouncementListDto, Announcement>();
            CreateMap<Announcement, AnnouncementListDto>();

            CreateMap<AnnouncementUpdateDto, Announcement>();
            CreateMap<Announcement, AnnouncementUpdateDto>();

            CreateMap<SendMessageDto, ContactUs>().ReverseMap();

        }
    }
}
