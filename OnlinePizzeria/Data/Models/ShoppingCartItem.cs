namespace OnlinePizzeria.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; init; }
        public Pizza Pizza { get; init; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; init; }
    }
}