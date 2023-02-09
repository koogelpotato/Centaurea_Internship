using Centaurea.Models;

public class ConcertViewModel
{
    public IEnumerable<ClassicalConcert> ClassicalConcerts { get; set; }
    public IEnumerable<RegularConcert> RegularConcerts { get; set; }
    public IEnumerable<Party> Parties { get; set; }
}
