using Centaurea_Project.Data;
using Centaurea_Project.Interfaces;
using Centaurea_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Centaurea_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConcertController : ControllerBase
    {
        private readonly IClassicalConcertRepository _classicConcertRepository;
        private readonly IRegularConcertRepository _regularConcertRepository;
        private readonly IPartyConcertRepository _partyConcertRepository;

        public ConcertController(IClassicalConcertRepository classicConcertRepository, IRegularConcertRepository regularConcertRepository, IPartyConcertRepository partyConcertRepository)
        {
            _classicConcertRepository = classicConcertRepository;
            _regularConcertRepository = regularConcertRepository;
            _partyConcertRepository = partyConcertRepository;
        }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<ClassicalConcert>))]
        public IActionResult GetClassicalConcerts()
        {
            var classicalConcerts = _classicConcertRepository.GetClassicalConcerts();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(classicalConcerts);
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<RegularConcert>))]
        public IActionResult GetRegularConcerts()
        {
            var regularConcerts = _regularConcertRepository.GetRegularConcerts();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(regularConcerts);
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Party>))]
        public IActionResult GetPartyConcerts()
        {
            var partyConcerts = _partyConcertRepository.GetParties();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(partyConcerts);
        }
    }
}
