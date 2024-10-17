using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASSIGMENTS.Pages
{
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string UserEmail { get; set; }

        [BindProperty]
        public string UserPhone { get; set; }

        public void OnGet()
        {
            // Logic to display the profile details can be placed here
        }

        public IActionResult OnPost()
        {
            // Logic to save the changes made to the profile details
            // In a real application, this data would be saved to a database

            return RedirectToPage(); // Refresh the page to display updated profile details
        }
    }
}
