using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ASSIGMENTS.Pages
    {
        public class TaskManagementModel : PageModel
        {
            [BindProperty]
            public string Title { get; set; }

            [BindProperty]
            public string Description { get; set; }

            public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();

            public void OnGet()
            {
                // Logic to display tasks can be placed here
            }

            public IActionResult OnPost()
            {
                // Add a new task (without saving to a database)
                if (!string.IsNullOrEmpty(Title))
                {
                    var newTask = new TaskItem
                    {
                        Title = Title,
                        Description = Description
                    };

                    Tasks.Add(newTask); // This would only be stored in memory for now
                }

                return RedirectToPage(); // Refresh the page to show updated task list
            }

            public class TaskItem
            {
                public string Title { get; set; }
                public string Description { get; set; }
            }
        }
    }


