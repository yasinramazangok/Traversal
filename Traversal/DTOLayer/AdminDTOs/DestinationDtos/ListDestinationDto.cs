namespace Traversal.DTOLayer.AdminDTOs.DestinationDtos
{
    public class ListDestinationDto
    {
        public int DestinationId { get; set; }
        public string? City { get; set; }
        public double? Price { get; set; }
        public int? Capacity { get; set; }
        public string? DayNight { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
