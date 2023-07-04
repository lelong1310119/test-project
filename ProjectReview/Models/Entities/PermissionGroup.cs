namespace ProjectReview.Models.Entities
{
    public class PermissionGroup
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public long CreateUserId { get; set; }

        public virtual User CreateUser { get; set; }
    }
}
