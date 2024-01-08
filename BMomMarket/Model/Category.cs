﻿using System;
using System.Collections.Generic;

namespace BMomMarket.Model;

public partial class Category
{
    public long CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
