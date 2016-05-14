using System;

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
}