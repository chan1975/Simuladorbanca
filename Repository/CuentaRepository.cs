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
    public class CuentaRepository : RepositoryBase<Cuenta>, ICuentaRepository
    {
        public CuentaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public async Task<Cuenta> GetCuentaAsync(int clienteId, int cuentaId, bool trackChanges)
        {
            return await FindByCondition(c => c.ClienteId == clienteId && c.Id == cuentaId, trackChanges).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Cuenta>> GetCuentasAsync(int clienteId, bool trackChanges)
        {
            return await FindByCondition(c => c.ClienteId == clienteId, trackChanges).ToListAsync();
        }
        public void CreateCuentaForCliente(int clienteId, Cuenta cuenta)
        {
            cuenta.ClienteId = clienteId;
            Create(cuenta);
        }

        public void DeleteCuenta(Cuenta cuenta)
        {
            Delete(cuenta);
        }

        
    }
}
