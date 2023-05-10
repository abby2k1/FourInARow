using Microsoft.AspNetCore.Mvc;
using Team9.Connect4.BL;

namespace Team9.Connect4.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavedGameController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BL.Models.SavedGame>>> Get()
        {
            try
            {
                return Ok(await SavedGameManager.Load());
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<BL.Models.SavedGame>>> Get(Guid id)
        {
            try
            {
                return Ok(await SavedGameManager.Load(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPost("{rollback?}")]
        public async Task<ActionResult> Post([FromBody] BL.Models.SavedGame savedGame, bool rollback = false)
        {
            try
            {
                await SavedGameManager.Insert(savedGame, rollback);
                return Ok(savedGame.Id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPut("{id}/{rollback?}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] BL.Models.SavedGame savedGame, bool rollback = false)
        {
            try
            {
                return Ok(await SavedGameManager.Update(savedGame, rollback));
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
                return Ok(await SavedGameManager.Delete(id, rollback));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }

}
