using System.ComponentModel.DataAnnotations;

namespace online_examination_system.Models
{
    public class ExamAttempt
    {
        [Key]
        public int AttemptId { get; set; }

        public int StudentId { get; set; }

        public int ExaminationId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        public Student Student { get; set; } = null!;

        public Examination Examination { get; set; } = null!;

        public ICollection<Answer> Answers { get; set; }
            = new List<Answer>();

        public Result? Result { get; set; }
    }
}