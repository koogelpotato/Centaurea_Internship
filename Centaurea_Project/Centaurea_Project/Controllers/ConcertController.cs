using Centaurea_Project.Data;
using Centaurea_Project.Interfaces;
using Centaurea_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Centaurea_Project.DTO;
using AutoMapper;

namespace Centaurea_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConcertController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClassicalConcertRepository _classicConcertRepository;
        private readonly IRegularConcertRepository _regularConcertRepository;
        private readonly IPartyConcertRepository _partyConcertRepository;
        private readonly IGenericRepository<ClassicalConcert> _classicConcertRepositoryBt;
        private readonly IGenericRepository<Party> _partyConcertRepositoryBt;
        private readonly IGenericRepository<RegularConcert> _regularConcertRepositoryBt;
        public ConcertController(IMapper mapper,IClassicalConcertRepository classicConcertRepository, IRegularConcertRepository regularConcertRepository, IPartyConcertRepository partyConcertRepository)
        {
            _mapper = mapper;
            _classicConcertRepository = classicConcertRepository;
            _regularConcertRepository = regularConcertRepository;
            _partyConcertRepository = partyConcertRepository;
        }
        [HttpGet("GetAllConcerts")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ConcertDTO>))]
        public IActionResult GetAllConcerts()
        {
            var classicalConcerts = _mapper.Map<List<ConcertDTO>>(_classicConcertRepository.GetClassicalConcerts());
            var regularConcerts = _mapper.Map<List<ConcertDTO>>(_regularConcertRepository.GetRegularConcerts());
            var partyConcerts = _mapper.Map<List<ConcertDTO>>(_partyConcertRepository.GetParties());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var allConcerts = new List<ConcertDTO>();
            allConcerts.AddRange(classicalConcerts);
            allConcerts.AddRange(regularConcerts);
            allConcerts.AddRange(partyConcerts);
            return Ok(allConcerts);
        }
        
        
    }
}
