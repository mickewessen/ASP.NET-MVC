using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityPortal.Data;

namespace UniversityPortal.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task CreateAdminAccountAsync()
        {
            if (!_userManager.Users.Any())
            {
                var user = new ApplicationUser()
                {
                    UserName = "admin@domain.com",
                    Email = "admin@domain.com",
                    FirstName = "Admin",
                    LastName = "Account"
                };

                var result = await _userManager.CreateAsync(user, "BytMig123!");

                if (result.Succeeded)
                {
                    if (!_roleManager.Roles.Any())
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                        await _roleManager.CreateAsync(new IdentityRole("Student"));
                        await _roleManager.CreateAsync(new IdentityRole("Teacher"));
                    }
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}
