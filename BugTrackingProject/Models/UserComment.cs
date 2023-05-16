using Microsoft.AspNetCore.Identity;

namespace BugTrackingProject.Models
{
    public class UserComment : IdentityUser
    {
        public ICollection<Comment> comments { get; set; }
    }
}
