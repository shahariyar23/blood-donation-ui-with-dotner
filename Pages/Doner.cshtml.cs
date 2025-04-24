using System.Net.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Doner
{
    public string Username { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Fullname { get; set; }
    public string? BloodType { get; set; }
    public string? Gender { get; set; }
    public string? Religion { get; set; }
    public string? SocialMedia { get; set; }
    public int TotalDonation { get; set; }
    public DateTime LastDonation { get; set; }
}

public class IndexModel : PageModel
{
    private readonly IHttpClientFactory _clientFactory;

    public IndexModel(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public List<Doner> Doners { get; set; } = new();

    public async Task OnGetAsync()
    {
        var client = _clientFactory.CreateClient();
        var response = await client.GetAsync("https://localhost:7034/api/User/get-all-doner");

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            Doners = JsonSerializer.Deserialize<List<Doner>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}