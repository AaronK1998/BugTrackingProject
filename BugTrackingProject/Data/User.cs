using System.ComponentModel.DataAnnotations;

namespace BugTrackingProject.Data
{
    public class User
    {
        [EmailAddress]
        [Required]
        public string loginName { get; set; } = string.Empty;

        [Required]
        public string userRole { get; set; } = string.Empty;
    }
}
