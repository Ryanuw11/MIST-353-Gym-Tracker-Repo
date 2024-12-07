using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class EmailPushModel : PageModel
{
    private readonly HttpClient _httpClient;

    public EmailPushModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Properties to bind form data
    [BindProperty]
    public string Email { get; set; } = string.Empty;

    [BindProperty]
    public string Subject { get; set; } = string.Empty;

    [BindProperty]
    public string Message { get; set; } = string.Empty;

    public IActionResult OnGet()
    {
        // Initialize or reset TempData messages on page load if needed
        TempData["ErrorMessage"] = null;
        TempData["SuccessMessage"] = null;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // Validate input fields
        if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Subject) || string.IsNullOrWhiteSpace(Message))
        {
            TempData["ErrorMessage"] = "All fields are required.";
            return Page();
        }

        // Prepare email data payload
        var emailData = new
        {
            Email = this.Email,
            Subject = this.Subject,
            Message = this.Message
        };

        try
        {
            // Serialize email data to JSON
            var content = new StringContent(JsonSerializer.Serialize(emailData), Encoding.UTF8, "application/json");

            // Send POST request to the email API
            var response = await _httpClient.PostAsync("https://localhost:7219/api/Emails", content);

            // Handle API response
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Email successfully sent!";
                return RedirectToPage("Success");
            }
            else
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                TempData["ErrorMessage"] = $"Failed to send email. Server responded with: {responseBody}";
                return Page();
            }
        }
        catch (Exception ex)
        {
            // Log the exception or handle it as necessary
            TempData["ErrorMessage"] = $"An error occurred while sending the email: {ex.Message}";
            return RedirectToPage("Error");
        }
    }
}


