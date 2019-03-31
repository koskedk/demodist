using System;
using System.Collections.Generic;

namespace Demo.BillLogs
{
    public class Invoice
    {
        public string Number { get; set; }
        public DateTime Period { get; set; }
        public decimal CallCharge { get; set; }
        public List<InvoiceLog> Logs { get; set; }=new List<InvoiceLog>();
    }
}
