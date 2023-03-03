using Centaurea_Project.Data.Enums;

namespace Centaurea_Project.DTO
{
    public class ConcertDTO
    {
        public int ConcertId { get; set; }
        public string PerformerName { get; set; }
        public int TicketsCount { get; set; }
        public DateTime PerformanceDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int? AgeLimit { get; set; }
        public VoiceTypes? VoiceType { get; set; }
        public string? ConcertName { get; set; }
        public string? ComposersName { get; set; }
    }
}
