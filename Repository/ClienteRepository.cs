using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
        public async Task<IEnumerable<Cliente>> GetAllClientesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<Cliente> GetClienteAsync(int clienteId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id == clienteId, trackChanges).SingleOrDefaultAsync();
        }
        public void CreateCliente(Cliente cliente)
        {
            Create(cliente);
        }

        public void DeleteCliente(Cliente cliente)
        {
            Delete(cliente);
        }
    }
}
