using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubscriptionManager.API.IServices;
using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.Controllers
{
    [Route("api/Subscriptions")]
    [ApiController]
    public class SubController : ControllerBase
    {
        private readonly ISubService _subService;

        public SubController(ISubService subService)
        {
            _subService = subService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionItem>>> GetAll()
        {
            try
            {
                var subs = await _subService.GetAllAsync();
                return Ok(subs);
            }
            catch (KeyNotFoundException kex)
            {
                return NotFound(kex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubscriptionItem>> GetById(string id)
        {
            try
            {
                var sub = await _subService.GetByIdAsync(id);
                return Ok(sub);
            }
            catch (KeyNotFoundException kex)
            {
                return NotFound(kex.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> Create(SubscriptionItem item) 
        {
            try
            {
                await _subService.CreateAsync(item);
                return CreatedAtAction(nameof(GetById), new { Id = item.Id }, item);
            }
            catch (ArgumentException aex)
            {
                return NotFound(aex.Message);
            }
        }

    }


}
