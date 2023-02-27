using Centaurea_Project.Models;

namespace Centaurea_Project.Interfaces
{
    public interface IPartyConcertRepository
    {
        ICollection<Party> GetParties();
    }
}
