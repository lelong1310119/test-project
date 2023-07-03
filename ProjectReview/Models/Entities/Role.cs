﻿using Microsoft.AspNetCore.Identity;

namespace ProjectReview.Models.Entities
{
    public class Role : IdentityRole<long>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
