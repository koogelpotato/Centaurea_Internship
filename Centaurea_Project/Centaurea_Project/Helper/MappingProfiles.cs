using AutoMapper;
using Centaurea_Project.DTO;
using Centaurea_Project.Models;

namespace Centaurea_Project.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<ClassicalConcert, ConcertDTO>();
            CreateMap<RegularConcert, ConcertDTO>();
            CreateMap<Party, ConcertDTO>();
        }
    }
}
