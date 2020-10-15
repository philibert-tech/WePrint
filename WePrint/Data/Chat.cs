using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WePrint.Data
{
    public class Chat
    {
        [Key]
        public string ChatId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public string Messsage { get; set; }
        public string Writer { get; set; }
        public DateTime DateSent { get; set; }
    }
}
