using System.ComponentModel.DataAnnotations;

namespace online_examination_system.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Role { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public Student? Student { get; set; }

        public Administrator? Administrator { get; set; }
    }
}