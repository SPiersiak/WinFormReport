using System;
using System.Collections.Generic;

namespace ReportData.Models;

public partial class Premise
{
    public long Id { get; set; }

    public string PremisesName { get; set; } = null!;

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
