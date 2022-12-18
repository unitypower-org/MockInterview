using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Domain.Entities.Interlocutor
{
    public class Booked
    {
        public int Id { get; set; }
        public int InterviewerId { get; set; }
        public int InterlocutorId { get; set; }
        public string BookedTime { get; set; } = string.Empty;
        public string PaymentAmount { get; set;} = string.Empty;
    }
}
