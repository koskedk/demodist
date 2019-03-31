using System;

namespace Demo.BillLogs
{
    public class InvoiceLog
    {
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string DialledNo { get; set; }
        public decimal Rate{ get; set; }
        public decimal Charge{ get; set; }
    }
}
