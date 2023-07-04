namespace ProjectReview.Models.Entities
{
    public class Job
    {
        public long Id { get; set; }    
        public long HostId { get; set; }
        public long InstructorId { get; set; }
        public long CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Request { get; set; }
        public 
    }
}
