using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CarFinanceCalculator.Domain
{
    public class AmortizationCalculator
    {
        private readonly decimal _monthlyPayment;
        private readonly List<AmortizationScheduleLine> _lines = new List<AmortizationScheduleLine>();

        public ReadOnlyCollection<AmortizationScheduleLine> Lines => new ReadOnlyCollection<AmortizationScheduleLine>(_lines); 

        public AmortizationCalculator(decimal monthlyPayment)
        {
            _monthlyPayment = monthlyPayment;
        }

        public void Calculate(CarLoan loan)
        {
            var monthlyInterestRate = loan.InterestRate/12;
            var paymentDate = loan.StartDate;
            var remainingPrincipal = loan.LoanAmount;

            foreach (var paymentNumber in Enumerable.Range(1, loan.Term))
            {
                // BUG: Rounding is off somehow using the following numbers, it is overpaid by 0.46 
                // at the end of the loan
                // Loan: 39203.27, Months 72, Rate: 0.0659, Payment: 669.69
                var interest = Math.Round(remainingPrincipal*monthlyInterestRate, 2);
                var thisMonthsPrincipal = Math.Round(_monthlyPayment - interest, 2);

                remainingPrincipal -= thisMonthsPrincipal;

                var line = new AmortizationScheduleLine(
                    paymentDate,
                    paymentNumber,
                    _monthlyPayment,
                    thisMonthsPrincipal,
                    interest,
                    remainingPrincipal);

                _lines.Add(line);
                paymentDate = paymentDate.AddMonths(1);
            }
        }
    }
}