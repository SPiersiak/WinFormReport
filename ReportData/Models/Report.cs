using System;
using System.Collections.Generic;

namespace ReportData.Models;

public partial class Report
{
    public long Id { get; set; }

    public string ReportName { get; set; } = null!;

    public long UserId { get; set; }

    public long PremisesId { get; set; }

    public DateTime ReportDateTime { get; set; }

    public virtual Premise Premises { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
