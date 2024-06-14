namespace VMO2.Data
{
    public class SalesResult
    {
        public string? Segment { get; set; }
        public string? Country { get; set; } 
        public string? Product { get; set; } 
        public string? Discount { get; set; }    
        public double UnitsSold { get; set; }  
        public double ManufacturingPrice { get; set; }
        public double SalePrice { get; set; }
        public DateOnly Date { get; set; }
    }
}
