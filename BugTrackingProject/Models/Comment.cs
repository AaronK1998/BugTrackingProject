using BugTrackingProject.Data;

namespace BugTrackingProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int BugId { get; set; }

        public string UserId { get; set; }

        public string CommentText { get; set; }

        public DateTime CreatedDate { get; set; }

        public UserComment User { get; set; }

        public Bug bug { get; set; }
    }
}
