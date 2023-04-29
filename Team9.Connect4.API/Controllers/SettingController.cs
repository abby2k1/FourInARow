using Microsoft.AspNetCore.Mvc;
using Team9.Connect4.BL;

namespace Team9.Connect4.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<BL.Models.Setting>>> Get(Guid id)
        {
            try
            {
                return Ok(await SettingManager.Load(id));
            }
            catch (Exception ex)
            {
                try
                {
                    return Ok(await SettingManager.LoadByPlayerId(id));
                }
                catch
                { }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPost("{rollback?}")]
        public async Task<ActionResult> Post([FromBody] BL.Models.Setting setting, bool rollback = false)
        {
            try
            {
                await SettingManager.Insert(setting, rollback);
                return Ok(setting.Id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPut("{id}/{rollback?}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] BL.Models.Setting setting, bool rollback = false)
        {
            try
            {
                return Ok(await SettingManager.Update(setting, rollback));
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
                return Ok(await SettingManager.Delete(id, rollback));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }

}
