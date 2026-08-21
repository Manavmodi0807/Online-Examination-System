using System.ComponentModel.DataAnnotations;

namespace online_examination_system.Models
{
    public class Examination
    {
        [Key]
        public int ExaminationId { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Duration { get; set; }

        public int TotalMarks { get; set; }

        public int PassingMarks { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        public int SubjectId { get; set; }

        public Subject Subject { get; set; } = null!;

        public ICollection<Question> Questions { get; set; }
            = new List<Question>();

        public ICollection<ExamAttempt> ExamAttempts { get; set; }
            = new List<ExamAttempt>();
    }
}