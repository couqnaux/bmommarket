using BMomMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMomMarket.DTO
{
    public class ProductDTO
    {
        public long ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? Description { get; set; }

        public long? Price { get; set; }

        public long? Quantity { get; set; }

        public string? Image { get; set; }
    }
}
