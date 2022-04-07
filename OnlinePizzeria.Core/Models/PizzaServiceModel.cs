using OnlinePizzeria.Data.Enum;
using Type = OnlinePizzeria.Data.Enum.Type;

namespace OnlinePizzeria.Core.Models
{
    public class PizzaServiceModel
    {
        public string Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public string ImageUrl { get; init; }
        public Type Type { get; init; }
        public decimal Price { get; init; }
        public Category Category { get; init; }
    }
}
