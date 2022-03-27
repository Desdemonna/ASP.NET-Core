using OnlinePizzeria.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = OnlinePizzeria.Data.Enum.Type;

namespace OnlinePizzeria.Core.Models
{
    public class PizzaServiceModel
    {
        private decimal price;
        public string Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public string ImageUrl { get; init; }
        public Type Type { get; init; }
        public decimal Price { get { return price; } set { price = value; } }
        public decimal PriceForMedium { get { return price * 1.25m; } }
        public decimal PriceForLarge { get { return price * 1.5m; } }
        public decimal PriceForFamily { get { return price * 2; } }
        public Category Category { get; init; }
    }
}
