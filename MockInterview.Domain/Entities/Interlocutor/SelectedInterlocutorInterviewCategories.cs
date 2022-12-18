using MockInterview.Domain.Entities.BaceModel;

namespace MockInterview.Domain.Entities.Interlocutor
{
    public class SelectedInterlocutorInterviewCategories : EntityBace
    {
        public int InterviewerId { get; set; }
        public string InterviewTime { get; set; } = string.Empty;
        public string InterviewPrice { get; set; } = string.Empty;
        public string InterviewerProjects { get; set; } = string.Empty;
        public int InterlocutorId { get; set; }
    }
}
