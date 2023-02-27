using Centaurea_Project.Models;

namespace Centaurea_Project.Interfaces
{
    public interface IRegularConcertRepository
    {
        ICollection<RegularConcert> GetRegularConcerts();
    }
}
