using System;

namespace CarFinanceCalculator.Domain
{
    public class AmortizationScheduleLine
    {
        public DateTime PaymentDate { get; set; }

        public int MonthNumber { get; set; }

        public decimal Payment { get; set; }

        public decimal Principal { get; set; }

        public decimal Interest { get; set; }

        public decimal RemainingPrincipal { get; set; }

        public AmortizationScheduleLine(
            DateTime paymentDate, 
            int monthNumber, 
            decimal payment, 
            decimal principal, 
            decimal interest, 
            decimal remainingPrincipal)
        {
            PaymentDate = paymentDate;
            MonthNumber = monthNumber;
            Payment = payment;
            Principal = principal;
            Interest = interest;
            RemainingPrincipal = remainingPrincipal;
        }
    }
}