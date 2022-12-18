namespace MockInterview.Domain.Models.Interlocutor
{
    public class BookedDTO
    {
        public int InterviewerId { get; set; }
        public int InterlocutorId { get; set; }
        public string BookedTime { get; set; } = string.Empty;
        public string PaymentAmount { get; set; } = string.Empty;
    }
}
