using System;

namespace Demo.Accounting
{
    public class Payment
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
