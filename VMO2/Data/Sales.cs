namespace VMO2.Data
{
    public class Sales : ISales
    {
        protected SalesResult _salesResult;

        public Sales(SalesResult salesResult)
        {
            _salesResult = salesResult;
        }
        public double GetProfitLoss()
        {
            double profit = _salesResult.UnitsSold * (_salesResult.SalePrice - _salesResult.ManufacturingPrice);
            return profit;
        }

        public bool IsProfit()
        {
            if (GetProfitLoss() >= 0)
            {
                return true;
            } else {
                return false;
            }
        }
        public bool IsLoss()
        {
            if (GetProfitLoss() < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
