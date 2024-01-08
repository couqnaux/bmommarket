using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMomMarket.DTO
{
    public class OrderDTO
    {
        public long OrderId { get; set; }

        public DateTime? OrderDate { get; set; }

        public string? CustomerName { get; set; }

        public string? EmployeeName { get; set; }

        public long? TotalPrice { get; set; }
    }
}
