using GymTrackersAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Gym_Tracker.Pages
{
    public class GymLocationModel : PageModel
    {
        private readonly HttpClient _httpClient;

       
        public GymLocationModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public IList<GymLoc> Locationlist { get; set; } = new List<GymLoc>();

        public async Task<IActionResult> OnGetAsync(string GymName)
        {
            if (string.IsNullOrEmpty(GymName))
            {
                ModelState.AddModelError("", "Please enter a valid city.");
                return Page();
            }

            try
            {
                string apiUrl = $"https://localhost:7219/apiLocation/{GymName}";
                var response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("API Response: " + jsonResponse);
                    if (string.IsNullOrEmpty(jsonResponse))
                    {
                        Console.WriteLine("API response is empty.");
                    }

                    
                    var location = JsonSerializer.Deserialize<List<GymLoc>>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (location != null && location.Any())
                    {
                        Locationlist = location; 
                    }
                    else
                    {
                        Locationlist = new List<GymLoc>();  
                    }
                }
                else
                {
                    Locationlist = new List<GymLoc>(); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
                ModelState.AddModelError("", $"An error occurred: {ex.Message}");
            }

            return Page();
        }
    }

}
