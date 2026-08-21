namespace online_examination_system.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public User User { get; set; } = null!;

        public ICollection<ExamAttempt> ExamAttempts { get; set; }
            = new List<ExamAttempt>();
    }
}