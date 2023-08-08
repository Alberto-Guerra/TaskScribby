using Microsoft.AspNetCore.Identity;
using TaskScribby.Areas.Identity.Data;

namespace TaskScribby.Areas.Identity.Services
{
    public class ProjectService
    {
        private readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<Project> GetAllProjects()
        {
            return _context.Projects.ToList();
        }

        public ICollection<Project> GetProjectsByUserID(String userID)
        {
            ICollection<Project> projects = new List<Project>();

            foreach(Project p in _context.Projects)
            {
                if(p.ApplicationUserId == userID)
                {
                    projects.Add(p);
                }
            }
            return projects; 
        }
        public void AddProject(Project project, ApplicationUser user)
        {

            user.Projects.Add(project);
            _context.SaveChanges();


        }

        public void DeleteProject(Project project)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public void UpdateProject( Project project, ApplicationUser user)
        {
            user.UpdateProject(project);
            _context.SaveChanges();
        }

    }
}
