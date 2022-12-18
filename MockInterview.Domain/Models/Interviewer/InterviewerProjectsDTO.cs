using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Domain.Models.Interviewer
{
    public class InterviewerProjectsDTO
    {
        public int InterviewerId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
    }
}
