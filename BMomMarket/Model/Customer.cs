using System;
using System.Collections.Generic;

namespace BMomMarket.Model;

public partial class Customer
{
    public long CustomerId { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
