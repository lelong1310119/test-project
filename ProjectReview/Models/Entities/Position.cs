﻿namespace ProjectReview.Models.Entities
{
    public class Position
    {
        public long Id { get; set; }    
        public string Name { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public long CreateUserId { get; set; }

        public virtual User CreateUser { get; set; }
    }
}
