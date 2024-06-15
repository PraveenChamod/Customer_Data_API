using Microsoft.AspNetCore.Identity;

namespace Data_Access_Layer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
