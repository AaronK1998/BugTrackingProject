using System;
using System.Collections.Generic;

namespace BugTrackingProject.Models;

public partial class BugDescription
{
    public int Id { get; set; }

    public string? SecondaryStatus { get; set; }

    public string? Importance { get; set; }

    public double? EstimateTimeTaken { get; set; }

    public double? TotalEstimatedTimeTaken { get; set; }

    public double? ActualTimeTaken { get; set; }

    public double? TotalTimeTaken { get; set; }

    public string? BugDesciption { get; set; }

}
