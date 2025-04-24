using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blood_donation_ui.Pages
{
    public class LoginModel(ILogger<LoginModel> logger) : PageModel
    {
        private readonly ILogger<LoginModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}
