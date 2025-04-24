using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blood_donation_ui.Pages
{
    public class SearchDonerModel(ILogger<SearchDonerModel> logger) : PageModel
    {
        private readonly ILogger<SearchDonerModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}