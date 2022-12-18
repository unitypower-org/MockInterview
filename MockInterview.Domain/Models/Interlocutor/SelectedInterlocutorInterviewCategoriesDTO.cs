using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Domain.Models.Interlocutor
{
    public class SelectedInterlocutorInterviewCategoriesDTO
    {
        public int InterviewerId { get; set; }
        public string InterviewTime { get; set; } = string.Empty;
        public string InterviewPrice { get; set; } = string.Empty;
        public string InterviewerProjects { get; set; } = string.Empty;
        public int InterlocutorId { get; set; }
    }
}
