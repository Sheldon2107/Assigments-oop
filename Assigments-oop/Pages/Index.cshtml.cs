using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASSIGMENTS.Pages
{
    public class IndexModel : PageModel
    {
        // This property will hold a simple message to be displayed on the page
        public string WelcomeMessage="";//{ get(); private set;}
        public void OnGet()
        {
            // Set a welcome message when the page is accessed
            WelcomeMessage = "Welcome to the Project Management Dashboard!";
        }
        public string get(){
            return WelcomeMessage;
        }
        public void set( string n){
            WelcomeMessage=n;
        }
    }
}
