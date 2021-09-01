using IdentitySamples.Mvc.Models.AAA.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySamples.Mvc.Models.Services
{
    public class UserNameNotInPasswordValidator : IPasswordValidator<ApplicationUser>
    {
        public virtual async Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user, string password)
        {
            var errors = new List<IdentityError>();
            if(password.Contains(user.UserName))
            {
                errors.Add(new IdentityError
                {
                    Code = "UserNameNotInPassword",
                    Description = "Using username in password is invalid"
                });
            }

            return errors.Count == 0 ?
                IdentityResult.Success :
                IdentityResult.Failed(errors.ToArray());
        }
    }

    public class BlackListPaswordValidator: UserNameNotInPasswordValidator
    {
        private readonly AaaDbContext _aaaDbContext;

        public BlackListPaswordValidator(AaaDbContext aaaDbContext)
        {
            _aaaDbContext = aaaDbContext;
        }
        public override async Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user, string password)
        {
            var result = await  base.ValidateAsync(manager, user, password);
            var errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();
            var isInBlackList = _aaaDbContext.blackListPasswordItems.Any(c => c.Value == password);
            
            if(isInBlackList)
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordInBlackList",
                    Description = "Using password that exists in blacklist is invalid"
                });
            }
            return errors.Count == 0 ?
                IdentityResult.Success :
                IdentityResult.Failed(errors.ToArray());
        }
    }
}
