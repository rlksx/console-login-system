namespace console_login_system.src.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}