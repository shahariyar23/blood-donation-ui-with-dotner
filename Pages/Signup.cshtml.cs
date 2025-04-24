using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blood_donation_ui.Pages
{
    public class SignupModel(ILogger<SignupModel> logger) : PageModel
    {
        private readonly ILogger<SignupModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}
