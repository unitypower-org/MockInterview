using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MockInterview.Domain.Entities.Client;
using MockInterview.Infrastructure.Context;
using MockInterview.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Infrastructure.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepasitory
    {
        public ClientRepository(MockInterviewDBContext dbContext, DbSet<Client> dbSet) : base(dbContext, dbSet)
        {
        }

        public async Task<Client> UpdateAsync(long id)
        {
            var client = await _dbSet.FindAsync(id);
            
            await _dbContext.SaveChangesAsync();

            return client;
        }
    }
}
