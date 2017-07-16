using System; 

namespace SimpleTimeTracker.Models
{
    public class Project
    {
        public Project()
        {
        }
        public  Guid Id { get; set; }
        public  string ProjectName { get; set; }
    }
}
