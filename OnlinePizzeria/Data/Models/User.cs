using Microsoft.AspNetCore.Identity;

namespace OnlinePizzeria.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Address { get; init; }
    }
}
