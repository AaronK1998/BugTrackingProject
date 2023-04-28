using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace BugTrackingProject.Models;

public class StoryBoard
{
    [Key]
    [Required]
    public int StoryBoardId { get; set; }

    public string? StoryBoardDescription { get; set; }

    public string? Status { get; set; }

    public int? LinkIssue { get; set; }

    public int? Priority { get; set; }

    public string? Assignee { get; set; }

    public int? BugId { get; set; }

    public virtual Bug? Bug { get; set; }

}
