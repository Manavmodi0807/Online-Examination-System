namespace online_examination_system.Models
{
    public class Administrator
    {
        public int AdministratorId { get; set; }

        public User User { get; set; } = null!;
    }
}