using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Team9.Connect4.BL.Models;
using Team9.Connect4.BL;

namespace Team9.Connect4.WebUI.Pages
{
    public class SettingsModel : PageModel
    {
        public Setting setting { get; set; }
        [BindProperty]
        public Guid PlayerId { get; set; }

        public void OnGet(Guid playerId)
        {
            PlayerId = playerId;
            setting = SettingManager.LoadByPlayerId(playerId);
        }
    }
}
