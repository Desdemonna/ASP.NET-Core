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
        public int Id { get; init; }
        public string Name { get; init; }

        [Required]
        [MaxLength(256)]
        public string Description { get; init; }
        public PizzaSize Size { get; init; }
        public PizzaType Type { get; init; }
        public decimal Price { get; init; }
        public ICollection<Feedback> Feedbacks { get; init; }
    }
}
