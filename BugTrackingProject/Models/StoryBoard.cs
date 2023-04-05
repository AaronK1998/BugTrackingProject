using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Models;

[Table("StoryBoard")]
public partial class StoryBoard
{
    [Key]
    [Column("StoryBoardID")]
    public int StoryBoardId { get; set; }

    public string? StoryBoardDescription { get; set; }

    public string? ChildIssues { get; set; }

    public int? LinkIssue { get; set; }

    public int? Priority { get; set; }

    [StringLength(450)]
    public string? Assignee { get; set; }


    [ForeignKey("LinkIssue")]
    [InverseProperty("StoryBoards")]
    public virtual Bug? LinkIssueNavigation { get; set; }
}
