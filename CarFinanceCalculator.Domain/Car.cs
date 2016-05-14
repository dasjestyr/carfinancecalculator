using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CarFinanceCalculator.Domain
{
    public class CarLoan
    {
        public Car Car { get; set; }

        public decimal LoanAmount { get; set; }

        public decimal InterestRate { get; set; }

        public int Term { get; set; }

        public DateTime StartDate { get; set; }

        public CarLoan(Car car, decimal loanAmount, decimal interestRate, int term, DateTime startDate)
        {
            Car = car;
            LoanAmount = loanAmount;
            InterestRate = interestRate;
            Term = term;
            StartDate = startDate;
        }
    }

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
            var loanDate = loan.StartDate;

            var monthlyInterestRate = loan.InterestRate/12;
            
            var paymentDate = loanDate;
            var remainingPrincipal = loan.LoanAmount;

            // BUG: Rounding is off somehow using the following numbers, it is off by 0.46 at the end of the loan
            // Loan: 39203.27, Months 72, Rate: 0.0659, Payment: 669.69

            foreach (var paymentNumber in Enumerable.Range(1, loan.Term))
            {
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

    public class Car
    {
        private readonly string _make;
        private readonly string _model;

        public Car(string make, string model)
        {
            _make = make;
            _model = model;
        }
    }
}
