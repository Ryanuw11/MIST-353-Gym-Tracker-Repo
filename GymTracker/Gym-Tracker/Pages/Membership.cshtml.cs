using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gym_TrackerAPI.Entities;
using System.Text.Json; // Your DbContext namespace



namespace Gym_Tracker.Pages
{

    public class MembershipLevelModel : PageModel
    {
        private readonly HttpClient _httpClient;


        public MembershipLevelModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public IList<Membership> MembershipList { get; set; } = new List<Membership>();

        public async Task<IActionResult> OnGetAsync(string MembershipLevel)
        {
            if (string.IsNullOrEmpty(MembershipLevel))
            {
                ModelState.AddModelError("", "Enter a valid Membership Level");
                return Page();
            }

            try
            {
                string apiUrl = $"https://localhost:7219/api/Memberships/{MembershipLevel}";
                var response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("API Response: " + jsonResponse);
                    if (string.IsNullOrEmpty(jsonResponse))
                    {
                        Console.WriteLine("API response is empty.");
                    }


                    var Level = JsonSerializer.Deserialize<List<Membership>>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (Level != null && Level.Any())
                    {
                        MembershipList = Level;
                    }
                    else
                    {
                        MembershipList = new List<Membership>();
                    }
                }
                else
                {
                    MembershipList = new List<Membership>();
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
