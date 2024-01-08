using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMomMarket.DTO
{
    public class OrderDetailDTO
    {
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public long Quantity { get; set; }
        public long Price { get; set; }
        public long TotalPrice { get; set; }
    }
}
