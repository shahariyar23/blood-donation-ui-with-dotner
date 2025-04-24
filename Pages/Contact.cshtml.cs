using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blood_donation_ui.Pages
{
    public class ContactModel(ILogger<ContactModel> logger) : PageModel
    {
        private readonly ILogger<ContactModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}
