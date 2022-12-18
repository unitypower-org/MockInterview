using Microsoft.EntityFrameworkCore;
using MockInterview.Domain.Entities.Client;
using MockInterview.Domain.Entities.Interlocutor;
using MockInterview.Domain.Entities.Interviewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Infrastructure.Context
{
    public class MockInterviewDBContext : DbContext
    {

        /// <summary>
        /// Clients table
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Bookeds table
        /// </summary>
        public DbSet<Booked> Bookeds { get; set; }

        /// <summary>
        /// Interlocators table
        /// </summary>
        public DbSet<Interlocutor> Interlocators { get; set; }

        /// <summary>
        /// SelectedInterlocatorsCategories table
        /// </summary>
        public DbSet<SelectedInterlocutorInterviewCategories> SelectedInterlocatorsCategories { get;set; }

        /// <summary>
        /// Interviewers table
        /// </summary>
        public DbSet<Interviewer> Interviewers { get; set; }

        /// <summary>
        /// InterviewersProjects table
        /// </summary>
        public DbSet<InterviewerProjects> InterviewersProjects { get; set; }

        /// <summary>
        /// connect models
        /// </summary>
        /// <param name="options"></param>
        public MockInterviewDBContext(DbContextOptions<MockInterviewDBContext> options): base(options) { }
        

    }
}
