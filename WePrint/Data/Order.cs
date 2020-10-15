using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WePrint.Data
{
    public class Order
    {
        [Key]
        public string OrderId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public string ProductId { get; set; }
    
        public string SizeChoosen { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
