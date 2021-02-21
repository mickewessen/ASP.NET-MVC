using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UniversityPortal.Data;

namespace UniversityPortal.Models
{
    public class ApplicationUserClaims : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ApplicationUserClaims(UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager, 
            IOptions<IdentityOptions> 
            options) : base(userManager, roleManager, options)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var _identity = await base.GenerateClaimsAsync(user);
            _identity.AddClaim(new Claim("DisplayName", $"{user.FirstName} {user.LastName}"));
            return _identity;
        }
    }
}
