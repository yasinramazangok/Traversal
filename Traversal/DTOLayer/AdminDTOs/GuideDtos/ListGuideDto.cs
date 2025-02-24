using Traversal.EntityLayer.Concretes;

namespace Traversal.DTOLayer.AdminDTOs.GuideDtos
{
    public class ListGuideDto
    {
        public int GuideId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool? Status { get; set; }
    }
}
