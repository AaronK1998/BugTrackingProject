using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Models;

[Table("Bug")]
public partial class Bug
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("productName")]
    [StringLength(50)]
    [Unicode(false)]
    public string ProductName { get; set; } = null!;

    [Column("component")]
    [StringLength(50)]
    [Unicode(false)]
    public string Component { get; set; } = null!;

    [Column("loginName")]
    [StringLength(256)]
    public string? LoginName { get; set; }

    [Column("bugHeading")]
    [StringLength(250)]
    [Unicode(false)]
    public string BugHeading { get; set; } = null!;

    [Column("status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [Column("lastUpdated")]
    public DateTime LastUpdated { get; set; }

    [Column("userID")]
    [StringLength(450)]
    public string? UserId { get; set; }

    [InverseProperty("LinkIssueNavigation")]
    public virtual ICollection<StoryBoard> StoryBoards { get; } = new List<StoryBoard>();

}
