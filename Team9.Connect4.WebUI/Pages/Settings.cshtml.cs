using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Team9.Connect4.BL.Models;
using Team9.Connect4.BL;
using Newtonsoft.Json;
using System.Text;

namespace Team9.Connect4.WebUI.Pages
{
    public class SettingsModel : PageModel
    {
        public async Task<IActionResult> OnPostSaveSettings(string boardColor, string playerColor, string opponentColor)
        {
            try
            {
                // Create a new Setting object
                var setting = new Setting()
                {
                    Id = Guid.NewGuid(),
                    BoardColor = boardColor,
                    PlayerColor = playerColor,
                    OpponentColor = opponentColor
                };

                // Make API request to save the settings
                using (var client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(setting);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("/api/Setting", content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle success
                        return RedirectToPage("/Index");
                    }
                    else
                    {
                        // Handle failure
                        var errorMessage = await response.Content.ReadAsStringAsync();
                        ModelState.AddModelError("", errorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            // Return the page with validation errors
            return Page();
        }
    

    public void OnGet()
        {
        }
    }
}
