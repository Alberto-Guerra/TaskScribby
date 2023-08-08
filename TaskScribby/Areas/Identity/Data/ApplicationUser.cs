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

        public void UpdateProject(Project project)
        {
            foreach(var p in Projects)
            {
                if(p.Id == project.Id)
                {
                    p.ProjectPercentage = project.ProjectPercentage;
                    p.ProjectName = project.ProjectName;
                    p.ProjectDescription = project.ProjectDescription;
                    
                }
            }
        }

    }
}
