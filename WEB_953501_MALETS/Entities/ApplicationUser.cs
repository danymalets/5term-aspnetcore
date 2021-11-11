using Microsoft.AspNetCore.Identity;

namespace WEB_953501_MALETS.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}