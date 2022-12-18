namespace MockInterview.Domain.Models.Client
{
    public class ClientDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Image { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
