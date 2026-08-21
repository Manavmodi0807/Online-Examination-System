using System.ComponentModel.DataAnnotations;

namespace online_examination_system.Models
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }

        [Required]
        public string OptionText { get; set; } = string.Empty;

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; } = null!;

        public ICollection<Answer> Answers { get; set; }
            = new List<Answer>();
    }
}