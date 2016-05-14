namespace CarFinanceCalculator.Domain
{
    public class Car
    {
        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public decimal Msrp { get; set; }

        public Car(int year, string make, string model, decimal msrp)
        {
            Year = year;
            Make = make;
            Model = model;
            Msrp = msrp;
        }
    }
}
