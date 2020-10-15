using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Data;

namespace WePrint.Models
{
    public class OrderVm
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public Product Product { get; set; }
        public string ProductId { get; set; }

        public string SizeChoosen { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
