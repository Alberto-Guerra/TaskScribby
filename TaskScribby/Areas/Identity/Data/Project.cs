using System.ComponentModel.DataAnnotations;

namespace TaskScribby.Areas.Identity.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        [Range(0.01, 9999.99)]
        public double ProjectPercentage { get; set; }
        public string ApplicationUserId { get; set; }

        public Project(string projectName, string projectDescription, double projectPercentage)
        {
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            ProjectPercentage = projectPercentage;
        }
    }
}
