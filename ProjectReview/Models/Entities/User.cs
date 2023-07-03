using Microsoft.AspNetCore.Identity;

namespace ProjectReview.Models.Entities
{
    public class User : IdentityUser<long>
    {
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
