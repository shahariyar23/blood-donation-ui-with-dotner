using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blood_donation_ui.Pages
{
    public class RequestBloodModel : PageModel
    {
        private readonly ILogger<RequestBloodModel> _logger;

        public RequestBloodModel(ILogger<RequestBloodModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
