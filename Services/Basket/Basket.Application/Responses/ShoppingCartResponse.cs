namespace Basket.Application.Responses
{
    public class ShoppingCartResponse
    {
        public string UserName { get; set; }
        public List<ShoppingCartItemResponse> Items { get; set; }

        public ShoppingCartResponse()
        {

        }
        public ShoppingCartResponse(string userName)
        {
            UserName = userName;
        }
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var items in Items)
                {
                    totalPrice += items.Price * items.Quantity;
                }
                return totalPrice;
            }
        }
    }
}
