using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rasiga_Camelia_Lab2.Pages
{
    public class AuthorsModel : PageModel
    {
        private readonly ILogger<AuthorsModel> _logger;

        public AuthorsModel(ILogger<AuthorsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
