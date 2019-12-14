using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApplication.Models
{
    public class CreditCardHistory
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public DateTime CreditDateTime { get; set; }
        public double Amount { get; set; }
    }
}
