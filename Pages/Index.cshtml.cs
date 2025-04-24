using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blood_donation_ui.Pages
{
    public class HomeModel(ILogger<HomeModel> logger) : PageModel
    {
        private readonly ILogger<HomeModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}
