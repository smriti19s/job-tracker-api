using System.ComponentModel.DataAnnotations;

namespace JOB_Tracker.API.DTOs
{
    public class JobDtoResponse
    {
        [Required]
        [MaxLength(100)]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }
        
        [Required]
        public string Position { get; set; }
       
        [Required]
        public int Status { get; set; }
       
        [Required]
        public DateTime AppliedDate { get; set; }

    }
}
