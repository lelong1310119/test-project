﻿using Microsoft.AspNetCore.Identity;

namespace ProjectReview.Models.Entities
{
    public class UserRole : IdentityUserRole<long>
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
