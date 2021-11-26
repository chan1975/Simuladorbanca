using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAllClientesAsync(bool trackChanges);
        Task<Cliente> GetClienteAsync(int clienteId, bool trackChanges);
        void CreateCliente(Cliente cliente);
        void DeleteCliente(Cliente cliente);
    }
}
