﻿using MockInterview.Domain.Entities.BaceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Domain.Entities.Interviewer
{
    public class InterviewerProjects : EntityBace
    {
        public int InterviewerId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
    }
}
