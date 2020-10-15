using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WePrint.Data;

namespace WePrint.Models
{
    public class AccountVm
    {
        public string AccountId { get; set; }
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

        public string BillingAddress { get; set; }
        public Int64 CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Cvv { get; set; }
    }
}
