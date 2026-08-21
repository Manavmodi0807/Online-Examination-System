using System.ComponentModel.DataAnnotations;

namespace online_examination_system.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string SubjectName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<Examination> Examinations { get; set; }
            = new List<Examination>();
    }
}