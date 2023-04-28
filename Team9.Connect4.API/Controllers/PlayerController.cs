using Microsoft.AspNetCore.Mvc;
using Team9.Connect4.BL;

namespace Team9.Connect4.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        // GET: api/<PlayerController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BL.Models.Player>>> Get()
        {
            try
            {
                return Ok(await PlayerManager.Load());
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<PlayerController>
        [HttpPost("{rollback}")]
        public async Task<ActionResult> Post([FromBody] BL.Models.Player player, bool rollback = false)
        {
            try
            {
                await PlayerManager.Insert(player, rollback);
                return Ok(player.Id);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}/{rollback?}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] BL.Models.Player player, bool rollback = false)
        {
            try
            {
                return Ok(await PlayerManager.Update(player, rollback));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}/{rollback?}")]
        public async Task<IActionResult> Delete(Guid id, bool rollback = false)
        {
            try
            {
                return Ok(await PlayerManager.Delete(id, rollback));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
