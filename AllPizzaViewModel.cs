using OnlinePizzeria.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.ViewModels
{
    public class AllPizzaViewModel
    {

        //private decimal price;

        [Required]
        public string Id { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public string ImageUrl { get; init; }

        public string TypeTitle { get; init; }

        public decimal Price { get; init; }
        //public decimal PriceForMedium { get { return price * 1.25m; } }
        //public decimal PriceForLarge { get { return price * 1.5m; } }
        //public decimal PriceForFamily { get { return price * 2; } }

        public string CategoryTitle { get; init; }

        [Range(
            1,
            long.MaxValue)]
        public long Quantity { get; set; }
    }
}
