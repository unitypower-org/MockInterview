using MockInterview.Domain.Entities.BaceModel;

namespace MockInterview.Domain.Entities.Interviewer
{
    public class InterviewerProjects : EntityBace
    {
        public int InterviewerId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
    }
}
