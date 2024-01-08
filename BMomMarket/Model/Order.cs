using System;
using System.Collections.Generic;

namespace BMomMarket.Model;

public partial class Order
{
    public long OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public long? CustomerId { get; set; }

    public long? EmployeeId { get; set; }

    public long? TotalPrice { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
