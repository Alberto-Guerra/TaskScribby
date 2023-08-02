using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TaskScribby.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        public ICollection<Project> Projects { get; set; } = new List<Project>();

        public void AddProject( Project project)
        {
            Projects.Add(project);
        }

        public void RemoveProject(Project project)
        {
            Projects.Remove(project);
        }

    }
}
