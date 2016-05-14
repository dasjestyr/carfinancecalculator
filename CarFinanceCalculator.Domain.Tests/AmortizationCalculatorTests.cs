using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarFinanceCalculator.Domain.Tests
{
    [TestClass]
    public class AmortizationCalculatorTests
    {
        [TestMethod]
        public void Test1()
        {
            var car = new Car(2009, "Infiniti", "G37", 38700);
            var loan = new CarLoan(car, 39203.27M, .0659M, 72, new DateTime(2012, 12, 3));
            var calc = new AmortizationCalculator(660.69M);
            var valueCalc = new DepreciationCalculator();

            calc.Calculate(loan);
            Trace.WriteLine("Date\t\tPayment\t\tInterest\tPrincipal\tRemaining\t\tValue\t\tEquity");
            foreach (var line in calc.Lines)
            {
                var value = Math.Round(valueCalc.Calculate(car, line.PaymentDate), 2);
                var equity = value - line.RemainingPrincipal;

                Trace.WriteLine($"{line.PaymentDate.ToShortDateString()}\t{line.Payment.ToString("C")}\t\t{line.Interest.ToString("C")}\t\t{line.Principal.ToString("C")}\t\t{line.RemainingPrincipal.ToString("C")}\t\t{value.ToString("C")}\t{equity.ToString("C")}");
            }

            var one = 1;
        }
    }
}
