using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarFinanceCalculator.Domain;

namespace CarFinanceCalculator.Forms.Views
{
    public partial class Main : Form
    {
        private int _year;
        private string _make;
        private string _model;
        private decimal _msrp;
        private decimal _monthlyPayment;
        private decimal _loanAmount;
        private decimal _apr;
        private int _term;
        private DateTime _startDate;

        private readonly List<SummaryLine> _displayLines = new List<SummaryLine>(); 
        private readonly List<AmortizationScheduleLine> _rawLines = new List<AmortizationScheduleLine>(); 

        public Main()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                MessageBox.Show(
                    "Check parameters...", 
                    "Input Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            Calculate();
        }

        private void Calculate()
        {
            dgSummary.DataSource = null;
            _displayLines.Clear();
            _rawLines.Clear();

            var car = new Car(_year, _make, _model, _msrp);
            var loan = new CarLoan(car, _loanAmount, _apr, _term, _startDate);
            var amortCalc = new AmortizationCalculator(_monthlyPayment);
            var carValueCalc = new DepreciationCalculator();

            amortCalc.Calculate(loan);
            foreach (var line in amortCalc.Lines)
            {
                var carValue = carValueCalc.Calculate(car, line.PaymentDate);
                var summaryLine = new SummaryLine(
                    line.PaymentDate,
                    line.Payment.ToString("C"),
                    line.Interest.ToString("C"),
                    line.Principal.ToString("C"),
                    line.RemainingPrincipal.ToString("C"),
                    carValue.ToString("C"),
                    (carValue - line.RemainingPrincipal).ToString("C"));

                _displayLines.Add(summaryLine);
            }

            var maturityDate = _displayLines.Last().PaymentDate.ToShortDateString();
            var equityDate = _displayLines.FirstOrDefault(p => !p.Equity.StartsWith("(")); // HACKZ0RZ

            lblMaturityDate.Text = maturityDate;
            lblEquityDate.Text = $"{equityDate?.PaymentDate.ToShortDateString() ?? "Never"}";

            BindGrid();
        }

        private void BindGrid()
        {
            dgSummary.DataSource = _displayLines;
        }

        private bool Validate()
        {
            _make = txtMake.Text;
            _model = txtModel.Text;
            _startDate = dpStartDate.Value;

            if (!int.TryParse(txtYear.Text, out _year))
                return false;


            if (!decimal.TryParse(txtMsrp.Text, out _msrp))
                return false;

            if (!decimal.TryParse(txtPayment.Text, out _monthlyPayment))
                return false;

            if (!decimal.TryParse(txtLoanAmount.Text, out _loanAmount))
                return false;

            if (!decimal.TryParse(txtRate.Text, out _apr) || _apr > 1 || _apr < 0)
                return false;

            if (!int.TryParse(txtTerm.Text, out _term))
                return false;

            return true;
        }
    }

    public class SummaryLine
    {
        public DateTime PaymentDate { get; set; }

        public string PaymentAmount { get; set; }

        public string InterestPaid { get; set; }

        public string PrincipalPaid { get; set; }

        public string RemainingBalance { get; set; }

        public string CarValue { get; set; }

        public string Equity { get; set; }

        public SummaryLine(
            DateTime paymentDate,
            string paymentAmount,
            string interestPaid,
            string principalPaid,
            string remainingBalance,
            string carValue,
            string equity)
        {
            PaymentDate = paymentDate;
            PaymentAmount = paymentAmount;
            InterestPaid = interestPaid;
            PrincipalPaid = principalPaid;
            RemainingBalance = remainingBalance;
            CarValue = carValue;
            Equity = equity;
        }
    }
}
