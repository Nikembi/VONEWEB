﻿using Microsoft.AspNetCore.Identity;
using VONEWEB.Enums;
using VONEWEB.Models;

namespace VONEWEB.Seeders
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            UserRole[] roles = { UserRole.admin, UserRole.vip, UserRole.user , UserRole.guest};

            foreach (var role in roles)
            {
                var roleName = role.ToString();

                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole<Guid>(roleName));
                }
            }
        }
    }
}
