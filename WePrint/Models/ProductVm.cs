using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Data;

namespace WePrint.Models
{
    public class ProductVm
    {

        public string ProductId { get; set; }
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
