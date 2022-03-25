using Microsoft.AspNet.Identity.EntityFramework;

namespace OnlinePizzeria.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
