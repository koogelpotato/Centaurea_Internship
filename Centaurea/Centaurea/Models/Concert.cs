using System.ComponentModel.DataAnnotations;

namespace Centaurea.Models
{
    public class Concert
    {
        [Key]
        public int ConcertId { get; set; }
        [Display(Name = "Performer name")]
        public string PerformerName { get; set; }
        [Display(Name = "Ticket ammout")]
        public int TicketsCount { get; set; }
        [Display(Name = "Date of performance")]
        public DateTime PerformanceDate { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Event discription")]
        public string Description { get; set; }
        [Display(Name = "Image source")]
        public string ImageURL { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
