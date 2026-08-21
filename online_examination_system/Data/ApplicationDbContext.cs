using Microsoft.EntityFrameworkCore;
using online_examination_system.Models;

namespace online_examination_system.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<ExamAttempt> ExamAttempts { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasOne(u => u.Student)
                .WithOne(s => s.User)
                .HasForeignKey<Student>(s => s.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Administrator)
                .WithOne(a => a.User)
                .HasForeignKey<Administrator>(a => a.AdministratorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Subject>()
                .HasMany(s => s.Examinations)
                .WithOne(e => e.Subject)
                .HasForeignKey(e => e.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Examination>()
                .HasMany(e => e.Questions)
                .WithOne(q => q.Examination)
                .HasForeignKey(q => q.ExaminationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Options)
                .WithOne(o => o.Question)
                .HasForeignKey(o => o.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.ExamAttempts)
                .WithOne(a => a.Student)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Examination>()
                .HasMany(e => e.ExamAttempts)
                .WithOne(a => a.Examination)
                .HasForeignKey(a => a.ExaminationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ExamAttempt>()
                .HasMany(a => a.Answers)
                .WithOne(a => a.ExamAttempt)
                .HasForeignKey(a => a.AttemptId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne(a => a.Question)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Option>()
                .HasMany(o => o.Answers)
                .WithOne(a => a.SelectedOption)
                .HasForeignKey(a => a.SelectedOptionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ExamAttempt>()
                .HasOne(a => a.Result)
                .WithOne(r => r.ExamAttempt)
                .HasForeignKey<Result>(r => r.AttemptId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Result>()
                .HasIndex(r => r.AttemptId)
                .IsUnique();
        }
    }
}