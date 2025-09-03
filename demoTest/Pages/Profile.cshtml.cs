using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demoTest.Pages
{
    public class ProfileModel : PageModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public void OnGet(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
