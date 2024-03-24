using System;
using System.Collections.Generic;

namespace ReportData.Models;

public partial class User
{
    public long Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
