using Microsoft.AspNet.Identity.EntityFramework;
using OnlinePizzeria.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; init; }
        public List<OrderDetail> OrderLines { get; init; }
        public DateTime CreatedOn { get; init; }
        public PaymentType PaymentType { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; init; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; init; }
        [StringLength(256)]
        public string Adress { get; init; }
        public Decimal Total { get; init; }
        public Status Status { get; init; }
        public string UserId { get; init; }
        public IdentityUser User { get; init; }
    }
}
