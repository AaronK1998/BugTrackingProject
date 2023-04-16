using System;
using System.Collections.Generic;

namespace BugTrackingProject.Models;

public partial class StoryBoard
{
    public int StoryBoardId { get; set; }

    public string? StoryBoardDescription { get; set; }

    public string? ChildIssues { get; set; }

    public int? LinkIssue { get; set; }

    public int? Priority { get; set; }

    public string? Assignee { get; set; }

    public int? BugId { get; set; }

    public virtual Bug? Bug { get; set; }
}
