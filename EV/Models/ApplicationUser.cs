using Microsoft.AspNetCore.Identity;

namespace EV.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string SecondName { get; set; }
    }
}
