using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlinePizzeria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Configuration
{
    internal sealed class Configuration 
    {
        public static void Initialize(AppDbContext context, IServiceProvider service)
        {
            context.Database.EnsureCreated();

            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = service.GetRequiredService<UserManager<IdentityUser>>();

            if (context.Pizzas.Any())
            {
                return;
            }
            CreateAdminRole(context, roleManager, userManager);
            CreateUserRole(context, roleManager, userManager);
        }

        private static void CreateAdminRole(AppDbContext context, RoleManager<IdentityRole> _roleManager, UserManager<IdentityUser> _userManager)
        {
            bool roleExists = _roleManager.RoleExistsAsync("Admin").Result;
            if (roleExists)
            {
                return;
            }

            var role = new IdentityRole()
            {
                Name = "Admin"
            };
            _roleManager.CreateAsync(role).Wait();

            var user = new IdentityUser()
            {
                UserName = "admin",
                Email = "admin@admin.com"
            };

            string adminPassword = "admin";
            var userResult = _userManager.CreateAsync(user, adminPassword).Result;

            if (userResult.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "Admin").Wait();
            }
        }

        private static void CreateUserRole(AppDbContext context, RoleManager<IdentityRole> _roleManager, UserManager<IdentityUser> _userManager)
        {
            var role = new IdentityRole()
            {
                Name = "User"
            };
            _roleManager.CreateAsync(role).Wait();

            var user = new IdentityUser()
            {
                UserName = "user",
                Email = "user@user.com"
            };

            string userPassword = "user";
            var userResult = _userManager.CreateAsync(user, userPassword).Result;

            if (userResult.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "User").Wait();
            }
        }



    }
}
