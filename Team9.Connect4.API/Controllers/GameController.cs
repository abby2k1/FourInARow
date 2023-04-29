using Microsoft.AspNetCore.Mvc;
using Team9.Connect4.BL;

namespace Team9.Connect4.API.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class GameController : ControllerBase
        {
            
            [HttpGet]
            public async Task<ActionResult<IEnumerable<BL.Models.Game>>> Get()
            {
                try
                {
                    return Ok(await GameManager.Load());
                }
                catch (Exception ex)
                {

                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
                
            }

            [HttpPost("{rollback?}")]
            public async Task<ActionResult> Post([FromBody] BL.Models.Game game, bool rollback = false)
            {
                try
                {
                    await GameManager.Insert(game, rollback);
                    return Ok(game.Id);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }

          
            [HttpPut("{id}/{rollback?}")]
            public async Task<IActionResult> Put(Guid id, [FromBody] BL.Models.Game game, bool rollback = false)
            {
                try
                {
                    return Ok(await GameManager.Update(game, rollback));
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }

            [HttpDelete("{id}/{rollback?}")]
            public async Task<IActionResult> Delete(Guid id, bool rollback = false)
            {
                try
                {
                    return Ok(await GameManager.Delete(id, rollback));

                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }
        }
    
}
