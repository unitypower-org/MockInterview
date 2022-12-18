using MockInterview.Domain.Entities.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Infrastructure.IRepositories
{
    public interface IClientRepasitory : IGenericRepository<Client>
    {
        Task<Client> UpdateAsync(long id);
    }
}
