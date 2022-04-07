using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePizzeria.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; init; }
        public Pizza Pizza { get; init; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(ShoppingCart))]
        public string ShoppingCartId { get; init; }
    }
}