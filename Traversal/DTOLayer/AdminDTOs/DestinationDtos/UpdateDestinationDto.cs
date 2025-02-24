using System.ComponentModel.DataAnnotations.Schema;
using Traversal.EntityLayer.Concretes;

namespace Traversal.DTOLayer.AdminDTOs.DestinationDtos
{
    public class UpdateDestinationDto
    {
        public int DestinationId { get; set; }
        public string? City { get; set; }
        public string? DayNight { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        public int? Capacity { get; set; }
        public string? CoverImage { get; set; }
        public string? Image2 { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set; }
    }
}
