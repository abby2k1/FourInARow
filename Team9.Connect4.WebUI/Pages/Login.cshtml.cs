using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Team9.Connect4.WebUI.Pages
{
    public class LoginModel : PageModel
    {
        public readonly DbContext _context;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public LoginModel(DbContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
            //var player = await _dbContext.tblPlayer.SingleOrDefaultAsync(player => player.Username == Username);
            //if (player != null && player.Password == Password)
            //{
                // Authentication successsful
                //var playerId = player.Id;
                // Immediately taking player to the settings page with the playerId
                //return RedirectToPage("/Settings", new { id = playerId });
            //}
            //else
            //{
                // Authentication failed
                //odelState.AddModelError(string.Empty, "Incorrect username or password");
                //return Page();
            //}
        //}

        public void OnGet()
        {
        }
    }
}
