using System.ComponentModel.DataAnnotations;

namespace Centaurea_Project.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public float Price { get; set; }

        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
        
    }
}
