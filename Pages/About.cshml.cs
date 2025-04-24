using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blood_donation_ui.Pages
{
    public class AboutModel(ILogger<AboutModel> logger) : PageModel
    {
        private readonly ILogger<AboutModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}
