using System.ComponentModel.DataAnnotations.Schema;

namespace JOB_Tracker.API.Models
{
    [Table("Notes", Schema = "jobtracker")]
    public class Note
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }

    }
}
