using Microsoft.AspNetCore.Identity;
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

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First name")]
        [StringLength(50)]
        public string FirstName { get; init; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last name")]
        [StringLength(50)]
        public string LastName { get; init; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; init; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(256)]
        public string Adress { get; init; }
        public Decimal Total { get; init; }
        public Status Status { get; init; }
        public string UserId { get; init; }
        public IdentityUser User { get; init; }
    }
}
