using System;
using System.Collections.Generic;

namespace DBFirstNorthwindMVC.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FullName { get; set; } = null!;

    public string? Title { get; set; }
}
