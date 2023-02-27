using Centaurea_Project.Models;
using System.ComponentModel.DataAnnotations;

public class ConcertViewModel
{
    public List<ClassicalConcert> ClassicalConcerts { get; set; }
    public List<RegularConcert> RegularConcerts { get; set; }
    public List<Party> Parties { get; set; }
}
