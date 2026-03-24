using System.ComponentModel.DataAnnotations.Schema;

namespace JOB_Tracker.API.Models
{
    [Table("Jobs", Schema = "jobtracker")]
    public class Job
    {

        public int Id { get; set; }

        public string CompanyName { get; set; }
        public string Position { get; set; }

        public int Status { get; set; }

        public DateTime AppliedDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
