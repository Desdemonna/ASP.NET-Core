using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Data.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; init; }
        public int OrderId { get; init; }
        public int PizzaId { get; init; }
        public int Quantity { get; init; }
        public Decimal Price { get; init; }
        public virtual Pizza Pizza { get; init; }
        public virtual Order Order { get; init; }
    }
}
