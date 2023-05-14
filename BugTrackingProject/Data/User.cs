using BugTrackingProject.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BugTrackingProject.Data
{
    public class User : IdentityUser
    {
        [EmailAddress]
        [Required]
        public string loginName { get; set; } = string.Empty;

        [Required]
        public string userRole { get; set; } = string.Empty;

        public ICollection<Comment> comments { get; set; }
        public ICollection<Bug> bugs { get; set; }
    }
}
