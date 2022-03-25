using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Data.Models
{
    public class PizzaType
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public decimal Price { get; set; }
    }
}
