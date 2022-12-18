using MockInterview.Domain.Entities.Client;
using MockInterview.Domain.Models.Client;
using MockInterview.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Application.ClientService
{
    public class ClientService : IClientService
    {
        private readonly IClientRepasitory _clientRepository;
        public Task<Client> CreateAsync(ClientDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Client, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetAsync(Expression<Func<Client, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateAsync(Client model)
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateStatusAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
