using System;

namespace CarFinanceCalculator.Domain
{
    public class DepreciationCalculator
    {
        public decimal Calculate(Car car, int age)
        {
            decimal valuePercentage;
            switch (age)
            {
                case 1:
                    valuePercentage = .65M;
                    break;
                case 2:
                    valuePercentage = .50M;
                    break;
                case 3:
                    valuePercentage = .40M;
                    break;
                case 4:
                    valuePercentage = .30M;
                    break;
                case 5:
                    valuePercentage = .25M;
                    break;
                case 6:
                    valuePercentage = .20M;
                    break;
                case 7:
                    valuePercentage = .15M;
                    break;
                default:
                    valuePercentage = .15M;
                    break;
            }

            return Math.Round(car.Msrp*valuePercentage, 2);
        }

        public decimal Calculate(Car car, DateTime onDate)
        {
            var age = onDate.Year - car.Year;

            if (age <= 0)
                age = 0;

            return Calculate(car, age);
        }
    }
}
