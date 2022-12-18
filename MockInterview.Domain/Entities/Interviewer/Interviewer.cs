using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Domain.Entities.Interviewer
{
    public class Interviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Level { get; set; }
        public string Experience { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile Image { get; set; }
        
    }
}
