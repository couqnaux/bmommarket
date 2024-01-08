using System;
using System.Collections.Generic;

namespace BMomMarket.Model;

public partial class Product
{
    public long ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Description { get; set; }

    public long? Price { get; set; }

    public long? Quantity { get; set; }

    public long? CategoryId { get; set; }

    public string? Image { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
