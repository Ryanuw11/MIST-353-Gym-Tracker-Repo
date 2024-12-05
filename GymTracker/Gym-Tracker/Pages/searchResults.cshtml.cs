using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymTrackersAPI.Entities;
using System.Text.Json;


namespace Gym_Tracker.Pages
{
    public class SearchResultsModel : PageModel
    {
        private readonly HttpClient _httpClient;

       
        public SearchResultsModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

       
        public IList<UserData> UserList { get; set; } = new List<UserData>();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id <= 0)
            {
                ModelState.AddModelError("", "Invalid ID.");
                return Page();
            }

            try
            {
                string apiUrl = $"https://localhost:7219/api/Gym/{id}";
                var response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("API Response: " + jsonResponse);
                    if (string.IsNullOrEmpty(jsonResponse))
                    {
                        Console.WriteLine("API response is empty.");
                    }

                   
                    var users = JsonSerializer.Deserialize<List<UserData>>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (users != null && users.Any())
                    {
                        UserList = users; 
                    }
                    else
                    {
                        UserList = new List<UserData>();  
                    }
                }
                else
                {
                    UserList = new List<UserData>(); 
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

