using GymTrackersAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

using System.Text.Json;

namespace Gym_Tracker.Pages
{
    public class recommendedApperalModel : PageModel
    {
        private readonly HttpClient _httpClient;
        public recommendedApperalModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IList<Apperal> Apperallist { get; set; } = new List<Apperal>();

        public async Task<IActionResult> OnGetAsync(int ApperalId)
        {
            if (ApperalId <= 0)
            {
                ModelState.AddModelError("", "Enter Apperal's ID Number");
                return Page();
            }
            else
            {
                try
                {
                    string apiUrl = $"https://localhost:7219/api/Apperals/ApperalGetAll?{ApperalId}";
                    var response = await _httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("API Response: " + jsonResponse);
                        if (string.IsNullOrEmpty(jsonResponse))
                        {
                            Console.WriteLine("API response is empty.");
                        }
                        var Apperal = JsonSerializer.Deserialize<List<Apperal>>(jsonResponse, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (Apperal != null && Apperal.Any())
                        {
                            Apperallist = Apperal;
                        }
                        else
                        {
                            Apperallist = new List<Apperal>();
                        }
                    }
                    else
                    {
                        Apperallist = new List<Apperal>();
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
}


