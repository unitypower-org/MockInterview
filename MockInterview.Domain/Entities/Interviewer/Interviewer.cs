using Microsoft.AspNetCore.Http;
using MockInterview.Domain.Entities.BaceModel;

namespace MockInterview.Domain.Entities.Interviewer
{
    public class Interviewer : EntityBace
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Image { get; set; }

    }
}
