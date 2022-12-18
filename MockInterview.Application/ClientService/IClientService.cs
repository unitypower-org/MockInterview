using MockInterview.Domain.Entities.Client;
using MockInterview.Domain.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Application.ClientService
{
    public interface IClientService
    {
        Task<Client> CreateAsync(ClientDTO model);
        Task<Client> GetAsync(Expression<Func<Client, bool>> predicate);
        Task<IEnumerable<Client>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Client, bool>> predicate = null);
        Task<Client> UpdateAsync(Client model);
        Task<Client> UpdateStatusAsync(long id);
    }
}
