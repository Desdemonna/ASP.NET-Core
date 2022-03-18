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
        public int Id { get; init; }
        public int OrderId { get; init; }
        public int Quantity { get; init; }
        public Decimal Price { get; init; }
        public Order Order { get; init; }
    }
}
