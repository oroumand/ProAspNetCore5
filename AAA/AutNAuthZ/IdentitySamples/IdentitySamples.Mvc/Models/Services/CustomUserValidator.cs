using IdentitySamples.Mvc.Models.AAA.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySamples.Mvc.Models.Services
{
    public class CustomUserValidator:UserValidator<ApplicationUser>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            var result = await base.ValidateAsync(manager, user);

            var errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();

            if(!user.Email.EndsWith("@nikamooz.com"))
            {
                errors.Add(new IdentityError
                {
                    Code = "InvalidOrganizationEmail",
                    Description = "Please use Nikamooz email"
                });
            }

            return errors.Count == 0 ?
                IdentityResult.Success :
                IdentityResult.Failed(errors.ToArray());
        }
    }
}
