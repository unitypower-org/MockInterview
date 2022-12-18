using MockInterview.Domain.Entities.BaceModel;

namespace MockInterview.Domain.Entities.Interlocutor
{
    public class Interlocutor : EntityBace
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
