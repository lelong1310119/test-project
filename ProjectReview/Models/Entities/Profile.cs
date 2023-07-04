﻿namespace ProjectReview.Models.Entities
{
    public class Profile
    {
        public long Id { get; set; }    
        public string Symbol { get; set; } 
        public string Title { get; set; }
        public string Expiry { get; set; }
        public DateTime Deadline { get; set; }
        public int Status { get; set; }
        public int OrderBy { get; set; }
        public DateTime CreateDate { get; set; }
        public long CreateUserId { get; set; }

        public virtual User CreateUser { get; set; }
    }
}
