using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Accounting
{
    public class Invoice
    {
        public string Number { get; set; }
        public DateTime Period { get; set; }
        public decimal CallCharge{ get; set; }
        public decimal Tax { get; set; }
        public decimal AmountDue { get; set; }
        public List<Payment> Payments { get; set; }=new List<Payment>();
        public string InvoiceStatus => GetStatus();

        private string GetStatus()
        {
            if (Payments.Any()&& Payments.Sum(x=>x.Amount)>=AmountDue)
            {
                return "Paid";
            }

            return "Not Paid";
        }
    }
}
