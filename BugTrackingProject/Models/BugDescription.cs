using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Models;

[Keyless]
[Table("BugDescription")]
public partial class BugDescription
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("secondaryStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SecondaryStatus { get; set; }

    [Column("importance")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Importance { get; set; }

    [Column("estimateTimeTaken")]
    public double? EstimateTimeTaken { get; set; }

    [Column("totalEstimatedTimeTaken")]
    public double? TotalEstimatedTimeTaken { get; set; }

    [Column("actualTimeTaken")]
    public double? ActualTimeTaken { get; set; }

    [Column("totalTimeTaken")]
    public double? TotalTimeTaken { get; set; }

    [Column("bugDesciption")]
    [Unicode(false)]
    public string? BugDesciption { get; set; }

    [ForeignKey("Id")]
    public virtual Bug IdNavigation { get; set; } = null!;
}
