using Microsoft.AspNetCore.Http;

namespace MockInterview.Domain.Models.Interviewer
{
    public class InterviewerDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Image { get; set; }
    }
}
