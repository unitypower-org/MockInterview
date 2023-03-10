using MockInterview.Domain.Entities.BaceModel;

namespace MockInterview.Domain.Entities.Interlocutor
{
    public class Booked : EntityBace
    {
        public int InterviewerId { get; set; }
        public int InterlocutorId { get; set; }
        public string BookedTime { get; set; } = string.Empty;
        public string PaymentAmount { get; set; } = string.Empty;
    }
}
