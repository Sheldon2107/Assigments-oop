using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Assigments_oop.Pages
{
    public class ProjectManagementModel : PageModel
    {
        [BindProperty]
        public string ProjectName { get; set; }

        [BindProperty]
        public string ProjectSummary { get; set; }

        [BindProperty]
        public DateTime ProjectDeadline { get; set; }

        public List<Project> Projects { get; set; } = new List<Project>();

        public void OnGet()
        {
            // Logic to display the project list can be placed here if needed
        }

        public IActionResult OnPost()
        {
            // Add a new project (without saving to a database)
            if (!string.IsNullOrEmpty(ProjectName) && !string.IsNullOrEmpty(ProjectSummary))
            {
                var newProject = new Project
                {
                    Name = ProjectName,
                    Summary = ProjectSummary,
                    Deadline = ProjectDeadline.ToUniversalTime(), // Convert to UTC
                    Tasks = new List<TaskItem>() // Initialize an empty list of tasks
                };

                Projects.Add(newProject); // This would only be stored in memory for now
            }

            return RedirectToPage(); // Refresh the page to show updated project list
        }

        public class Project
        {
            public string Name { get; set; }
            public string Summary { get; set; }
            public DateTime Deadline { get; set; }
            public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        }

        public class TaskItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Status { get; set; } // e.g., "Complete" or "Pending"
        }
    }
}
