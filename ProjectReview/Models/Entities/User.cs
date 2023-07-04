
namespace ProjectReview.Models.Entities
{
    public class User
    {
        public long Id { get; set; }    
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public long PositionId { get; set; }
        public long DepartmentId { get; set; }
        public long PermissionGroupId { get; set; }
        public long RankId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public long CreateUserId { get; set; }

        public virtual User CreateUser { get; set; }
        public virtual Position Position { get; set; }
        public virtual Department Department { get; set; }
        public virtual PermissionGroup PermissionGroup { get; set; }
        public virtual Rank Rank { get; set; }
    }
}
