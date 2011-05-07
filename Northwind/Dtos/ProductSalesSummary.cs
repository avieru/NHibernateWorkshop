namespace Northwind.Dtos
{
    public class ProductSalesSummary
    {
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public long ItemsSold { get; private set; }

        // TODO: try to remove this constructor and see what breaks
        protected ProductSalesSummary() {}

        public ProductSalesSummary(int productId, string productName, long itemsSold)
        {
            ProductId = productId;
            ProductName = productName;
            ItemsSold = itemsSold;
        }
    }
}