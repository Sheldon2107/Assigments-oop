using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ASSIGMENTS.Pages
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AssociatedProject { get; set; }
    }

    public class ClientModel : PageModel
    {
        [BindProperty]
        public string ClientName { get; set; }

        [BindProperty]
        public string ClientEmail { get; set; }

        [BindProperty]
        public string ClientPhoneNumber { get; set; }

        [BindProperty]
        public string ClientAssociatedProject { get; set; }

        public List<Client> Clients { get; set; } = new List<Client>();

        public void OnGet()
        {
            // This method is intentionally left blank as there's no data fetching
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(ClientName) && !string.IsNullOrEmpty(ClientEmail))
            {
                var newClient = new Client
                {
                    Name = ClientName,
                    Email = ClientEmail,
                    PhoneNumber = ClientPhoneNumber,
                    AssociatedProject = ClientAssociatedProject
                };
                // The client data would normally be processed here, but it's left empty intentionally
            }

            return RedirectToPage(); // Refresh the page
        }
    }
}
