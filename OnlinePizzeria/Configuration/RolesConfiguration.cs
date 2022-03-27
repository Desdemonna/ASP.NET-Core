using Microsoft.AspNetCore.Identity;
using OnlinePizzeria.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Configuration
{
    public class RolesConfiguration
    {
        public static async Task RolesAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Data.Enum.Roles.Customer.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Data.Enum.Roles.Admin.ToString()));
        }

        public static async Task AdminAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {

            var defaultUser = new User
            {
                UserName = "Admin",
                Email = "admin@admin.com",
                FirstName = "Mihaela",
                LastName = "Shikova",
                PhoneNumber = "0000000000",
                EmailConfirmed = false,
                PhoneNumberConfirmed = false
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Admin");
                    await roleManager.CreateAsync(new IdentityRole(Data.Enum.Roles.Customer.ToString()));
                    await roleManager.CreateAsync(new IdentityRole(Data.Enum.Roles.Admin.ToString()));
                }
            }
        }
    }
}
