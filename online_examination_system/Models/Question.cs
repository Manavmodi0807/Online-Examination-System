using System.ComponentModel.DataAnnotations;

namespace online_examination_system.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Required]
        public string QuestionText { get; set; } = string.Empty;

        public int Marks { get; set; }

        public int ExaminationId { get; set; }

        public Examination Examination { get; set; } = null!;

        public ICollection<Option> Options { get; set; }
            = new List<Option>();

        public ICollection<Answer> Answers { get; set; }
            = new List<Answer>();
    }
}