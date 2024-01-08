using System;
using System.Collections.Generic;

namespace BMomMarket.Model;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
