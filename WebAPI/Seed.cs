using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Core.Entities;
using Newtonsoft.Json;

namespace TempProject.WebAPI
{
    public class Seed
    {
        public static void SeedUsers(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            if (!userManager.Users.Any())
            {
                var userData = System.IO.File.ReadAllText("UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);

                //create some roles
                var roles = new List<Role>
                {
                    new Role{Name = "Admin" },
                    new Role{Name = "Manager" },
                    new Role{Name = "Employee" },
                    new Role{Name = "EndUser" }
                };
                foreach (var role in roles)
                {
                    roleManager.CreateAsync(role).Wait();
                }

                foreach (var user1 in users)
                {
                    userManager.CreateAsync(user1, "password").Wait();
                    userManager.AddToRoleAsync(user1, "Employee");
                }

                //Create admin user 
                var adminUser = new User
                {
                    UserName = "Admin"
                };

                var result = userManager.CreateAsync(adminUser, "password").Result;

                if (result.Succeeded)
                {
                    var admin = userManager.FindByNameAsync("Admin").Result;
                    userManager.AddToRolesAsync(admin, new[] { "Admin", "Manager" });
                }

            }
        }

    }
}
