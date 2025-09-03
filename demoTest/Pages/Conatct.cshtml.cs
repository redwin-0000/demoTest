using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demoTest.Pages
{
    public class ConatctModel : PageModel
    {
        [BindProperty]
        public List<string>? Name { get; set; }
        [BindProperty]
        public string? Email { get; set; }
        [BindProperty]
        public string? Phone { get; set; }

        public IActionResult OnPost()
        {
            // Redirect to Profile page with query string
            return RedirectToPage("Profile", new { name = Name, email = Email, phone = Phone });
        }
    }
}
