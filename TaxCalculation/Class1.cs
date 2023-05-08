global using TaxCalculation;


namespace TaxCalculation
{
    public class TaxBracket
    {
        public double UpperLimit {get; set;}
        public double LowerLimit { get; set;}
        public double TaxPercentage { get; set; }
    }

    public class CalculateTax
    {
        public List<TaxBracket> TaxBrackets { get; set; }

        public CalculateTax()
        {
             TaxBrackets = new List<TaxBracket>
            {
                new TaxBracket { LowerLimit = 0, UpperLimit = 1000, TaxPercentage = 0.10 },
                new TaxBracket { LowerLimit = 1000, UpperLimit = 5000, TaxPercentage = 0.20 },
                new TaxBracket { LowerLimit = 5000, UpperLimit = double.PositiveInfinity, TaxPercentage = 0.35 }
            };
        }

        //returns max value among two
        private static double MaxIncome(double a, double b)
        {
            return a > b ? a : b;
        }

        public double CalculateAdditionalTotalTax(double usualIncome, double additionalIncome)
        {
            double totalTax = 0;
            double remainingIncome = additionalIncome;

            foreach (var item in TaxBrackets)
            {
                if (usualIncome < item.UpperLimit)
                {
                    //calculate taxableincome
                    double taxApplicableIncome = remainingIncome < (item.UpperLimit - usualIncome) ? remainingIncome : (item.UpperLimit - usualIncome);
                    
                    double taxAmount = taxApplicableIncome * item.TaxPercentage;

                    //adds tax after each iteration
                    totalTax += taxAmount;
                    remainingIncome = remainingIncome - taxApplicableIncome;   

                    if (remainingIncome == 0)
                    {
                        break;
                    }
                }

                usualIncome = MaxIncome(0, usualIncome - item.UpperLimit);
            }

            return totalTax;
        }

    }

}