using System.ComponentModel.DataAnnotations;

namespace JOB_Tracker.API.DTOs
{
    public class CreateJobDtoRequest
    {
        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Position { get; set; }

        [Required]
        public int Status { get; set; }
       
        [Required]
        public DateTime AppliedDate { get; set; }
       
        [Required]
        public int UserId { get; set; }
    }
}
