using System.ComponentModel.DataAnnotations;

namespace online_examination_system.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }

        public int AttemptId { get; set; }

        public int TotalMarks { get; set; }

        public int ObtainedMarks { get; set; }

        public int CorrectAnswers { get; set; }

        public int IncorrectAnswers { get; set; }

        [Required]
        [StringLength(20)]
        public string ResultStatus { get; set; } = string.Empty;

        public DateTime PublishedAt { get; set; }

        public ExamAttempt ExamAttempt { get; set; } = null!;
    }
}