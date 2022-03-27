using OnlinePizzeria.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Data.Models
{
    public class Pizza
    {
        private decimal price;
        public Pizza()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        [Key]
        public string Id { get; init; } = Guid.NewGuid().ToString();
        public string Name { get; init; }

        [Required]
        [MaxLength(256)]
        public string Description { get; init; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; init; }
        public Enum.Type Type { get; init; }
        public decimal Price { get { return price; } set { price = value; } }
        public decimal PriceForMedium { get { return price * 1.25m; } }
        public decimal PriceForLarge { get { return price * 1.5m; } }
        public decimal PriceForFamily { get { return price * 2; } }
        public Category Category { get; init; }
        public ICollection<Feedback> Feedbacks { get; init; }
    }
}
