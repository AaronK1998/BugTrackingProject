using BugTrackingProject.Data;
using System;
using System.Collections.Generic;

namespace BugTrackingProject.Models;

public partial class Bug
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string Component { get; set; } = null!;

    public string? LoginName { get; set; }

    public string BugHeading { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public string? UserId { get; set; }

    public string? SecondaryStatus { get; set; }

    public string? Importance { get; set; }

    public double? EstimateTimeTaken { get; set; }

    public double? TotalEstimatedTimeTaken { get; set; }

    public double? ActualTimeTaken { get; set; }

    public double? TotalTimeTaken { get; set; }

    public string? BugDesciption { get; set; }

    public ICollection<Comment> comment { get; set; }

    public UserComment User { get; set; }
}
