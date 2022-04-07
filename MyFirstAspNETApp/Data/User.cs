using Microsoft.AspNetCore.Identity;
using OnlinePizzeria.Data.Models;
using System.Collections.Generic;

namespace OnlinePizzeria.Data
{
    public class User : IdentityUser
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Address { get; set; }

        public ICollection<Order> Orders { get; init; } = new HashSet<Order>();
    }
}
