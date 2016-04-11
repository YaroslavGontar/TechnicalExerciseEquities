namespace FundManagerDashboard.Core.Model
{
    public class Stock
    {
        public StockType Type { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public long Id { get; set; }
    }
}
