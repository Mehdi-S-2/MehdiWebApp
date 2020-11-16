using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MehdiWebApp.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminRoleName = "Administrator";
            await roleManager.CreateAsync(new IdentityRole(adminRoleName));

            // TODO: Add admin username and password by using "User Secrets Manager"
            string adminUserName = "admin@mng.com";
            string adminPassword = "Aa@123456";
            var adminUser = new ApplicationUser { UserName = adminUserName };
            await userManager.CreateAsync(adminUser, adminPassword);

            adminUser = await userManager.FindByNameAsync(adminUserName);
            await userManager.AddToRoleAsync(adminUser, adminRoleName);
        }
    }
}
