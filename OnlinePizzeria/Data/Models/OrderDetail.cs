using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Data.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; init; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; init; }

        [ForeignKey(nameof(Pizza))]
        public string PizzaId { get; init; }
        public int Quantity { get; init; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; init; }
        public virtual Pizza Pizza { get; init; }
        public virtual Order Order { get; init; }
    }
}
