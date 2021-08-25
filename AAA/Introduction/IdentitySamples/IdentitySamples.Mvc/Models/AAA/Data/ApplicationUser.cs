using Microsoft.AspNetCore.Identity;

namespace IdentitySamples.Mvc.Models.AAA.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Ssn { get; set; }
    }
}
