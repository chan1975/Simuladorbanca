using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICuentaRepository
    {
        Task<IEnumerable<Cuenta>> GetCuentasAsync(int clienteId, bool trackChanges);
        Task<Cuenta> GetCuentaAsync(int clienteId, int cuentaId, bool trackChanges);
        void CreateCuentaForCliente(int clienteId, Cuenta cuenta);
        void DeleteCuenta(Cuenta cuenta);
    }
}
