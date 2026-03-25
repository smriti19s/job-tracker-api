namespace JOB_Tracker.API.DTOs
{
    public class UpdateJobDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public int Status { get; set; }
        public DateTime AppliedDate { get; set; }
    }
}
