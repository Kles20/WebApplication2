using Microsoft.AspNetCore.Identity;

namespace eDziennik.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
