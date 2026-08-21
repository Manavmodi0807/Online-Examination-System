using System.ComponentModel.DataAnnotations;

namespace online_examination_system.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }

        public int AttemptId { get; set; }

        public int QuestionId { get; set; }

        public int SelectedOptionId { get; set; }

        public bool IsCorrect { get; set; }

        public int MarksObtained { get; set; }

        public ExamAttempt ExamAttempt { get; set; } = null!;

        public Question Question { get; set; } = null!;

        public Option SelectedOption { get; set; } = null!;
    }
}