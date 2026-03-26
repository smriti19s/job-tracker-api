using System.ComponentModel.DataAnnotations;

namespace JOB_Tracker.API.DTOs
{
    public class UpdateJobDto
    {
        //[Required]
        //public int Id { get; set; }
        
        [Required]
        public string CompanyName { get; set; }
        
        [Required]
        public string Position { get; set; }
        
        [Required]
        public int Status { get; set; }

        public DateTime AppliedDate { get; set; }
    }
}
