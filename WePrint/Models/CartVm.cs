using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Data;

namespace WePrint.Models
{
    public class CartVM
    {
        public string CartId { get; set; }
        public Product Product { get; set; }
        public string ProductId { get; set; }
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Size { get; set; }
        public DateTime DateInserted { get; set; }
    }
}
