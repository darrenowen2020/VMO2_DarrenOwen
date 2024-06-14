namespace VMO2.Data
{
    public class SalesAnalysis : SalesResult
    {
        private double _ProfitLoss;
        private bool _IsProfit;
        private bool _IsLoss;
        private Sales _sales;

        public SalesAnalysis(SalesResult salesResult)
        {
            base.Country = salesResult.Country;
            base.ManufacturingPrice = salesResult.ManufacturingPrice;
            base.Product = salesResult.Product;
            base.SalePrice = salesResult.SalePrice;
            base.UnitsSold = salesResult.UnitsSold;
            base.Country = salesResult.Country;
            base.Date = salesResult.Date;
            base.Discount = salesResult.Discount;
            base.Segment = salesResult.Segment;

            _sales = new Sales(salesResult);

        }
        public double ProfitLoss
        {
            get
            {
                return _sales.GetProfitLoss();
            }
        }
        public bool IsProfit
        {
            get
            {
                return _sales.IsProfit();
            }
        }
        public bool IsLoss {
            get
            {
                return _sales.IsLoss();
            }
        }
    }
}
