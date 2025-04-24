using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blood_donation_ui.Pages
{
    public class UserProfileModel(ILogger<UserProfileModel> logger) : PageModel
    {
        private readonly ILogger<UserProfileModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}
