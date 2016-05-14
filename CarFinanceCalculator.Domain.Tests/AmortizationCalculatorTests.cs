using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarFinanceCalculator.Domain.Tests
{
    [TestClass]
    public class AmortizationCalculatorTests
    {
        [TestMethod]
        public void Test1()
        {
            var car = new Car("Infiniti", "G37");
            var loan = new CarLoan(car, 39203.27M, .0659M, 72, new DateTime(2012, 12, 3));
            var calc = new AmortizationCalculator(660.69M);

            calc.Calculate(loan);
            Trace.WriteLine("Date\t\tPayment\t\tInterest\tPrincipal\tRemaining");
            foreach (var line in calc.Lines)
            {
                Trace.WriteLine($"{line.PaymentDate.ToShortDateString()}\t{line.Payment.ToString("C")}\t\t{line.Interest.ToString("C")}\t\t{line.Principal.ToString("C")}\t\t{line.RemainingPrincipal.ToString("C")}");
            }

            var one = 1;
        }
    }
}
