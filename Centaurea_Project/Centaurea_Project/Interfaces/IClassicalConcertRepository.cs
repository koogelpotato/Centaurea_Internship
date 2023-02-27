using Centaurea_Project.Models;

namespace Centaurea_Project.Interfaces
{
    public interface IClassicalConcertRepository
    {
        ICollection<ClassicalConcert> GetClassicalConcerts();
    }
}
