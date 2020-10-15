using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WePrint.Data
{
    public class Cart
    {
        [Key]
        public string  CartId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public string ProductId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Size { get; set; }
        public DateTime DateInserted { get; set; }
    }
}
