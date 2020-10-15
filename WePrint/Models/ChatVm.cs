using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Data;

namespace WePrint.Models
{
    public class ChatVm
    {
        public string ChatId { get; set; }
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public string Messsage { get; set; }
        public string Writer { get; set; }
        public DateTime DateSent { get; set; }
    }
}
