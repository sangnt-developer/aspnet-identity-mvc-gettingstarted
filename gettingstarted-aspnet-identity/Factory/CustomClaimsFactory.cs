using gettingstarted_aspnet_identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace gettingstarted_aspnet_identity.Factory
{
    public class CustomClaimsFactory : UserClaimsPrincipalFactory<User>
    {
        public CustomClaimsFactory(UserManager<User> userManager, IOptions<IdentityOptions> opitonsAccessor)
            : base(userManager, opitonsAccessor)
        {

        }

        protected async override Task<ClaimsIdentity> GenerateClaimsAsync(User user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("firstName", user.FirstName));
            identity.AddClaim(new Claim("lastName", user.LastName));
            return identity;
        }
    }
}
