using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASSIGMENTS.Pages
{
    public class Project
    {
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public string Summary { get; set; }
        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }

    public class TaskItem
    {
        public string Description { get; set; }
        public string Status { get; set; } // e.g., "Complete" or "Pending"
    }

    public class DashboardModel : PageModel
    {
        public List<Project> Projects { get; set; } = new List<Project>();

        public int TotalProjects => Projects.Count;
        public int CompletedTasks => Projects.Sum(p => p.Tasks.Count(t => t.Status == "Complete"));
        public int PendingTasks => Projects.Sum(p => p.Tasks.Count(t => t.Status == "Pending"));

        public void OnGet()
        {
            // No data fetching from Firestore as it has been removed
        }
    }
}
