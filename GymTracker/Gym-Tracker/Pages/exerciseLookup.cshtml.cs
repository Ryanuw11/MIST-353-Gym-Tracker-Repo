using GymTrackersAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Gym_Tracker.Pages
{
    public class exerciseLookupModel : PageModel
    {

        private readonly HttpClient _httpClient;
        public exerciseLookupModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IList<Exercise> Exerciselist { get; set; } = new List<Exercise>();

        public async Task<IActionResult> OnGetAsync(int ExerciseId)
        {
            if (ExerciseId <= 0)
            {
                ModelState.AddModelError("", "Search by exercise ID");
                return Page();
            }
            else
            {
                try
                {
                    string apiUrl = $"'https://localhost:7219/api/Exercise/ExerciseGetAll?{ExerciseId}";
                    var response = await _httpClient.GetAsync(apiUrl);



                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("API Response: " + jsonResponse);
                        if (string.IsNullOrEmpty(jsonResponse))
                        {
                            Console.WriteLine("API response is empty.");
                        }

                        var Apperal = JsonSerializer.Deserialize<List<Exercise>>(jsonResponse, new JsonSerializerOptions
                        {

                            PropertyNameCaseInsensitive = true
                        });


                        if (Exercise != null && Exercise.Any())
                        {
                            Exerciselist = Exercise;
                        }
                        else
                        {
                            Exerciselist = new List<Exercise>();
                        }
                    }

                    else
                    {
                        Exerciselist = new List<Exercise>();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occurred: {ex.Message}");
                    ModelState.AddModelError("", $"An error occurred: {ex.Message}");
                }

                return Page();
            }
        } } }
