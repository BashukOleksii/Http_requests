using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using SubscriptionManager.API.IServices;
using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeopleItem>>> GetAll()
        {
            try
            {
                var peoples = await _peopleService.GetAllAsync();
                return Ok(peoples);
            }
            catch (KeyNotFoundException kex)
            {
                return NotFound(kex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PeopleItem>> GetById(string id)
        {
            try
            {
                var people = await _peopleService.GetByIdAsync(id);
                return Ok(people);
            }
            catch (KeyNotFoundException kex)
            {
                return NotFound(kex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(PeopleItem people)
        {
            await _peopleService.CreateAsync(people);

            return CreatedAtAction(nameof(GetById), new { Id = people.Id }, people);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id,PeopleItem people)
        {
            try
            {
               await _peopleService.UpdateAsync(id,people);
                return NoContent();

            }
            catch (KeyNotFoundException kex)
            {
                return NotFound(kex.Message);
            }
        }



    }
}
