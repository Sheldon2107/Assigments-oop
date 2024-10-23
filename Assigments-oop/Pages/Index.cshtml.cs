using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASSIGMENTS.Pages
{
    public class IndexModel : PageModel
    {
        // This property holds the welcome message to be displayed on the page
        public string WelcomeMessage { get; private set; }

        // This method runs when the page is accessed
        public void OnGet()
        {
            // Set the welcome message
            WelcomeMessage = "Welcome to the Project Management Dashboard!";
        }
    }
}
