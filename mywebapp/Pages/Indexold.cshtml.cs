using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace mywebapp.Pages
{
    public class IndexoldModel : PageModel
    {
        private readonly ILogger<IndexoldModel> _logger;

        public IndexoldModel(ILogger<IndexoldModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}