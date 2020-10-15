using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WePrint.Data
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string CategoryId { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public string Gender { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public string Decoration { get; set; }
    }
}
